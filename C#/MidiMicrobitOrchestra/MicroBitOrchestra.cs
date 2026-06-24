using NAudio.Midi;
using System.IO.Ports;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MidiMicrobitOrchestra
{
    public partial class MicroBitOrchestra : Form
    {

        NAudio.Midi.MidiOut midiOut;
        MessageFilter firewall = new MessageFilter();
        public MicroBitOrchestra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event handler: Refresh list of midi devices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMidiRefresh_Click(object sender, EventArgs e)
        {
            UpdateMidiOutDevices();
        }

        /// <summary>
        /// Update the list of midi output devices (e.g. keyboards and software synths)
        /// </summary>
        void UpdateMidiOutDevices()
        {
            lstMidiOutputDevices.Items.Clear();
            for (int i = 0; i < NAudio.Midi.MidiOut.NumberOfDevices; i++)
            {
                lstMidiOutputDevices.Items.Add(NAudio.Midi.MidiOut.DeviceInfo(i).ProductName);
            }
        }

        /// <summary>
        /// Button click event handler: connect to selected MIDI device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMidiOutConnect_Click(object sender, EventArgs e)
        {
            midiOut = new NAudio.Midi.MidiOut(lstMidiOutputDevices.SelectedIndex);
        }

        /// <summary>
        /// Button click event handler: send a note to the selected MIDI output device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMidiTest_Click(object sender, EventArgs e)
        {
            int noteNumber = int.Parse(txtNoteNumber.Text);
            if (midiOut != null)
            {
                midiOut.Send(new NAudio.Midi.NoteOnEvent(0, 1, noteNumber, 127, 500).GetAsShortMessage());
            }
            else
            {
                lstLog.Items.Add("Not connected to a MIDI device");
            }
        }

        /// <summary>
        /// Button click event handler: refresh the list of serial ports (needed if you plug in the microbit after starting the program)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialRefresh_Click(object sender, EventArgs e)
        {
            UpdateSerialPortNames();
        }

        /// <summary>
        /// Refresh the list of serial ports. Each microbit creates a virtual serial port when you plug it in which lets you access the python REPL
        /// </summary>
        void UpdateSerialPortNames()
        {
            string[] names = SerialPort.GetPortNames();
            lstSerialPorts.Items.Clear();
            foreach (string name in names)
            {
                lstSerialPorts.Items.Add(name);
            }
        }

        /// <summary>
        /// Form load event handler: tasks to run on startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MicroBitOrchestra_Load(object sender, EventArgs e)
        {
            UpdateSerialPortNames();
            UpdateMidiOutDevices();
            comboChannel.SelectedIndex = 0;
            SetTextSize(16);
            WindowState = FormWindowState.Maximized;
        }

        SerialPort port;

        /// <summary>
        /// Button click event handler: connect to the selected serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSerialConnect_Click(object sender, EventArgs e)
        {
            if (port != null)
            {
                port.Close();
            }
            // You can connect to the micropython REPL at 115200bps
            port = new SerialPort(lstSerialPorts.SelectedItem.ToString(), 115200);

            // add event handler that's triggered whenever the microbit prints anything to the REPL
            port.DataReceived += Port_DataReceived;
            port.Open();
        }

        void ProcessMessage(string msg)
        {
            // check the message against the firewall rules
            if (!firewall.IsAllowed(msg))
            {
                Invoke(() =>
                {
                    lblRules.Text = $"Message '{msg.Trim()}' is blocked by firewall";
                });
                return;
            }

            // this event handler will run in a different thread from the main program thread so Invoke is required before interacting with the UI
            lstLog.Invoke(() =>
            {
                // display the message on the log list
                lstLog.Items.Add(msg);
                lstLog.SelectedIndex = lstLog.Items.Count - 1;
            });

            // use a regular expression to detect an integer in the received message data
            Match m = Regex.Match(msg, "(\\d+)");
            if (m.Success)
            {
                // extract the MIDI note number from the received data
                int note = int.Parse(m.Groups[1].Value);
                int channel = 1;

                lstLog.Invoke(() =>
                {
                    lstLog.Items.Add($"Note On: {note}");

                    switch (comboChannel.SelectedIndex)
                    {
                        // channel 0 = normal channel 1 (MIDI channels are 0-15 but displayed as 1-16 in most software)
                        case 0:
                            channel = 1;
                            break;
                        // channel 10 = percussion
                        case 1:
                            channel = 10;
                            break;
                        // channel as second integer in the message
                        case 2:
                            m = Regex.Match(msg, ("\\d+\\s+(\\d+)"));
                            if (m.Success)
                            {
                                channel = int.Parse(m.Groups[1].Value);
                                if (channel < 1)
                                    channel = 1;
                                if (channel > 16)
                                    channel = 16;
                            }
                            break;
                    }
                });

                // if we're connected to a MIDI output device then trigger a NoteOn message
                if (midiOut != null)
                {
                    // See https://mayerwin.github.io/MIDI-Notes-Player/ for an interactive description of MIDI note numbers
                    midiOut.Send(new NoteOnEvent(0, channel, note, 127, 200).GetAsShortMessage());
                }
            }
        }

        /// <summary>
        /// Serial port event handler: data has been received.
        /// This will happen whenver the micropython program on the microbit tries to print something:
        /// There's no console output on the microbit: print() will NOT scroll text on the 5x5 LED screen
        /// But you can still see the output of print() if you connect to the REPL (Read Evaluate Print Loop) via the serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Any form of network connection is likely to go wrong...
            try
            {
                // read the data from the REPL
                string data = port.ReadLine();

                ProcessMessage(data);

            }
            /// ... so be prepared for errors and log them gracefully
            catch (Exception ex)
            {
                lstLog.Invoke(() =>
                {
                    lstLog.Items.Add($"Error: {ex.Message}");
                });
            }

        }

        /// <summary>
        /// Button event handler: Stop the selected note (send a MIDI NoteOff event)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            int noteNumber = int.Parse(txtNoteNumber.Text);
            midiOut.Send(new NAudio.Midi.NoteOnEvent(0, 1, noteNumber, 0, 500).GetAsShortMessage());
        }

        /// <summary>
        /// Menu item event handler: clear the log list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        /// <summary>
        /// Menu item event handler: export the log list to a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.Title = "Export log to text file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(dlg.FileName))
                {
                    foreach (var item in lstLog.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }
        /// <summary>
        /// Menu item event handler: load rules from a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.Title = "Load rules from text file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRuleEditor.Text = File.ReadAllText(dlg.FileName);
            }
        }

        /// <summary>
        /// Menu item event handler: save rules to a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.Title = "Save rules to text file";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txtRuleEditor.Text);
            }
        }

        /// <summary>
        /// Update the rules in the firewall based on the text in the rule editor
        /// </summary>
        void UpdateRules()
        {
            firewall.rules.Clear();
            string rules = txtRuleEditor.Text;

            foreach (string line in rules.Split("\n"))
            {
                MessageRule r = new MessageRule(line);
                if (r.ruleType != RuleType.Invalid)
                {
                    firewall.rules.Add(r);
                }
            }

            lstRules.Items.Clear();
            foreach (MessageRule r in firewall.rules)
            {
                lstRules.Items.Add(r.ToString());
            }

            string test = txtTestMessage.Text;

            lblRules.Text = $"{firewall.rules.Count} rules loaded: Test '{test}'" +
                (firewall.IsAllowed(test) ? " allowed" : " blocked");
        }

        /// <summary>
        /// Text changed event handler: update the rules after a short delay to avoid updating on every keystroke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRuleEditor_TextChanged(object sender, EventArgs e)
        {
            lblRules.Text = "Waiting...";
            ruleUpdateTimer.Enabled = false;
            ruleUpdateTimer.Enabled = true;
            ruleUpdateTimer.Start();
        }

        /// <summary>
        /// Timer event handler: update the rules after a short delay to avoid updating on every keystroke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruleUpdateTimer_Tick(object sender, EventArgs e)
        {
            ruleUpdateTimer.Stop();
            lblRules.Text = "Checking...";
            UpdateRules();
        }

        /// <summary>
        /// Button click event handler: test the message filter with the text in the test message box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (firewall.IsAllowed(txtTestMessage.Text))
            {
                lblRules.Text = $"Message '{txtTestMessage.Text}' is allowed";
                ProcessMessage(txtTestMessage.Text);
            }
            else
            {
                lblRules.Text = $"Message '{txtTestMessage.Text}' is blocked";
            }

        }

        /// <summary>
        /// Button click event handler: clear the log list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        /// <summary>
        /// Stores the current size of all text on the form
        /// </summary>
        int textSize = 10;

        /// <summary>
        /// Recursively changes the text size of every control on the form
        /// </summary>
        /// <param name="newSize">New font size</param>
        void SetTextSize(int newSize)
        {
            textSize = newSize;
            SetTextSizeRecursive(this, newSize);
        }

        /// <summary>
        /// Sets the font size recursively for a control and all its child controls
        /// </summary>
        /// <param name="c">The control to update</param>
        /// <param name="newSize">The new font size</param>
        private void SetTextSizeRecursive(Control c, int newSize)
        {
            Font f = new Font(FontFamily.GenericSansSerif, newSize);
            c.Font = f;
            foreach (Control child in c.Controls)
            {
                SetTextSizeRecursive(child, newSize);
            }
        }

        /// <summary>
        /// Button click event handler: increase the text size of all controls on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLargerText_Click(object sender, EventArgs e)
        {
            SetTextSize(textSize + 1);
        }

        /// <summary>
        /// Button click event handler: decrease the text size of all controls on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSmallerText_Click(object sender, EventArgs e)
        {
            SetTextSize(textSize - 1);
        }

        /// <summary>
        /// Text changed event handler: update the rules after a short delay to avoid updating on every keystroke
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTestMessage_TextChanged(object sender, EventArgs e)
        {
            lblRules.Text = "Waiting...";
            ruleUpdateTimer.Enabled = false;
            ruleUpdateTimer.Enabled = true;
            ruleUpdateTimer.Start();
        }
    }
}