using NAudio.Midi;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace MidiMicrobitOrchestra
{
    public partial class MicroBitOrchestra : Form
    {

        NAudio.Midi.MidiOut midiOut;
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
            midiOut.Send(new NAudio.Midi.NoteOnEvent(0, 1, noteNumber, 127, 500).GetAsShortMessage());
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
                
                // this event handler will run in a different thread from the main program thread so Invoke is required before interacting with the UI
                lstLog.Invoke(() =>
                {
                    // display the message on the log list
                    lstLog.Items.Add(data);
                    lstLog.SelectedIndex = lstLog.Items.Count - 1;
                });

                // use a regular expression to detect an integer in the received message data
                Match m = Regex.Match(data, "(\\d+)");
                if (m.Success)
                {
                    // extract the MIDI note number from the received data
                    int note = int.Parse(m.Groups[1].Value);

                    lstLog.Invoke(() =>
                    {
                        lstLog.Items.Add($"Note On: {note}");
                    });

                    // if we're connected to a MIDI output device then trigger a NoteOn message
                    if (midiOut != null)
                    {
                        // See https://mayerwin.github.io/MIDI-Notes-Player/ for an interactive description of MIDI note numbers
                        midiOut.Send(new NoteOnEvent(0, 1, note, 127, 200).GetAsShortMessage());
                    }
                }
            } 
            /// ... so be prepared for errors and log them gracefully
            catch(Exception ex)
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
    }
}
