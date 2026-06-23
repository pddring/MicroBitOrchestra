namespace MidiMicrobitOrchestra
{
    partial class MicroBitOrchestra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            tabControls = new TabControl();
            tabMidiOutputDevices = new TabPage();
            grpMidiOutput = new GroupBox();
            flowMidiOutputButtons = new FlowLayoutPanel();
            btnMidiOutConnect = new Button();
            btnMidiRefresh = new Button();
            btnMidiTest = new Button();
            txtNoteNumber = new TextBox();
            btnStop = new Button();
            lstMidiOutputDevices = new ListBox();
            tabSerialPort = new TabPage();
            grpSerialPorts = new GroupBox();
            flowSerialButtons = new FlowLayoutPanel();
            btnSerialConnect = new Button();
            btnSerialRefresh = new Button();
            btnSerialDisconnect = new Button();
            lstSerialPorts = new ListBox();
            tabLog = new TabPage();
            groupBox1 = new GroupBox();
            lstLog = new ListBox();
            menu.SuspendLayout();
            tabControls.SuspendLayout();
            tabMidiOutputDevices.SuspendLayout();
            grpMidiOutput.SuspendLayout();
            flowMidiOutputButtons.SuspendLayout();
            tabSerialPort.SuspendLayout();
            grpSerialPorts.SuspendLayout();
            flowSerialButtons.SuspendLayout();
            tabLog.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, logToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 3;
            menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem, exportToolStripMenuItem });
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(39, 20);
            logToolStripMenuItem.Text = "&Log";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "&Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "&Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // tabControls
            // 
            tabControls.Controls.Add(tabMidiOutputDevices);
            tabControls.Controls.Add(tabSerialPort);
            tabControls.Controls.Add(tabLog);
            tabControls.Dock = DockStyle.Fill;
            tabControls.Location = new Point(0, 24);
            tabControls.Name = "tabControls";
            tabControls.SelectedIndex = 0;
            tabControls.Size = new Size(800, 617);
            tabControls.TabIndex = 4;
            // 
            // tabMidiOutputDevices
            // 
            tabMidiOutputDevices.Controls.Add(grpMidiOutput);
            tabMidiOutputDevices.Location = new Point(4, 24);
            tabMidiOutputDevices.Name = "tabMidiOutputDevices";
            tabMidiOutputDevices.Padding = new Padding(3);
            tabMidiOutputDevices.Size = new Size(792, 589);
            tabMidiOutputDevices.TabIndex = 0;
            tabMidiOutputDevices.Text = "MIDI Settings";
            tabMidiOutputDevices.UseVisualStyleBackColor = true;
            // 
            // grpMidiOutput
            // 
            grpMidiOutput.Controls.Add(flowMidiOutputButtons);
            grpMidiOutput.Controls.Add(lstMidiOutputDevices);
            grpMidiOutput.Dock = DockStyle.Fill;
            grpMidiOutput.Location = new Point(3, 3);
            grpMidiOutput.Name = "grpMidiOutput";
            grpMidiOutput.Size = new Size(786, 583);
            grpMidiOutput.TabIndex = 1;
            grpMidiOutput.TabStop = false;
            grpMidiOutput.Text = "Midi Output Device:";
            // 
            // flowMidiOutputButtons
            // 
            flowMidiOutputButtons.Controls.Add(btnMidiOutConnect);
            flowMidiOutputButtons.Controls.Add(btnMidiRefresh);
            flowMidiOutputButtons.Controls.Add(btnMidiTest);
            flowMidiOutputButtons.Controls.Add(txtNoteNumber);
            flowMidiOutputButtons.Controls.Add(btnStop);
            flowMidiOutputButtons.Dock = DockStyle.Bottom;
            flowMidiOutputButtons.Location = new Point(3, 549);
            flowMidiOutputButtons.Name = "flowMidiOutputButtons";
            flowMidiOutputButtons.Size = new Size(780, 31);
            flowMidiOutputButtons.TabIndex = 1;
            // 
            // btnMidiOutConnect
            // 
            btnMidiOutConnect.Location = new Point(3, 3);
            btnMidiOutConnect.Name = "btnMidiOutConnect";
            btnMidiOutConnect.Size = new Size(75, 23);
            btnMidiOutConnect.TabIndex = 2;
            btnMidiOutConnect.Text = "&Connect";
            btnMidiOutConnect.UseVisualStyleBackColor = true;
            btnMidiOutConnect.Click += btnMidiOutConnect_Click;
            // 
            // btnMidiRefresh
            // 
            btnMidiRefresh.Location = new Point(84, 3);
            btnMidiRefresh.Name = "btnMidiRefresh";
            btnMidiRefresh.Size = new Size(75, 23);
            btnMidiRefresh.TabIndex = 3;
            btnMidiRefresh.Text = "&Refresh";
            btnMidiRefresh.UseVisualStyleBackColor = true;
            btnMidiRefresh.Click += btnMidiRefresh_Click;
            // 
            // btnMidiTest
            // 
            btnMidiTest.Location = new Point(165, 3);
            btnMidiTest.Name = "btnMidiTest";
            btnMidiTest.Size = new Size(116, 23);
            btnMidiTest.TabIndex = 4;
            btnMidiTest.Text = "&Test (Note On)";
            btnMidiTest.UseVisualStyleBackColor = true;
            btnMidiTest.Click += btnMidiTest_Click;
            // 
            // txtNoteNumber
            // 
            txtNoteNumber.Location = new Point(287, 3);
            txtNoteNumber.Name = "txtNoteNumber";
            txtNoteNumber.Size = new Size(100, 23);
            txtNoteNumber.TabIndex = 5;
            txtNoteNumber.Text = "64";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(393, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 6;
            btnStop.Text = "Note Off";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // lstMidiOutputDevices
            // 
            lstMidiOutputDevices.Dock = DockStyle.Fill;
            lstMidiOutputDevices.FormattingEnabled = true;
            lstMidiOutputDevices.ItemHeight = 15;
            lstMidiOutputDevices.Location = new Point(3, 19);
            lstMidiOutputDevices.Name = "lstMidiOutputDevices";
            lstMidiOutputDevices.Size = new Size(780, 561);
            lstMidiOutputDevices.TabIndex = 0;
            // 
            // tabSerialPort
            // 
            tabSerialPort.Controls.Add(grpSerialPorts);
            tabSerialPort.Location = new Point(4, 24);
            tabSerialPort.Name = "tabSerialPort";
            tabSerialPort.Padding = new Padding(3);
            tabSerialPort.Size = new Size(792, 589);
            tabSerialPort.TabIndex = 1;
            tabSerialPort.Text = "Micro:bit Settings";
            tabSerialPort.UseVisualStyleBackColor = true;
            // 
            // grpSerialPorts
            // 
            grpSerialPorts.Controls.Add(flowSerialButtons);
            grpSerialPorts.Controls.Add(lstSerialPorts);
            grpSerialPorts.Dock = DockStyle.Fill;
            grpSerialPorts.Location = new Point(3, 3);
            grpSerialPorts.Name = "grpSerialPorts";
            grpSerialPorts.Size = new Size(786, 583);
            grpSerialPorts.TabIndex = 2;
            grpSerialPorts.TabStop = false;
            grpSerialPorts.Text = "Serial Ports:";
            // 
            // flowSerialButtons
            // 
            flowSerialButtons.Controls.Add(btnSerialConnect);
            flowSerialButtons.Controls.Add(btnSerialRefresh);
            flowSerialButtons.Controls.Add(btnSerialDisconnect);
            flowSerialButtons.Dock = DockStyle.Bottom;
            flowSerialButtons.Location = new Point(3, 549);
            flowSerialButtons.Name = "flowSerialButtons";
            flowSerialButtons.Size = new Size(780, 31);
            flowSerialButtons.TabIndex = 1;
            // 
            // btnSerialConnect
            // 
            btnSerialConnect.Location = new Point(3, 3);
            btnSerialConnect.Name = "btnSerialConnect";
            btnSerialConnect.Size = new Size(75, 23);
            btnSerialConnect.TabIndex = 2;
            btnSerialConnect.Text = "C&onnect";
            btnSerialConnect.UseVisualStyleBackColor = true;
            btnSerialConnect.Click += btnSerialConnect_Click;
            // 
            // btnSerialRefresh
            // 
            btnSerialRefresh.Location = new Point(84, 3);
            btnSerialRefresh.Name = "btnSerialRefresh";
            btnSerialRefresh.Size = new Size(75, 23);
            btnSerialRefresh.TabIndex = 3;
            btnSerialRefresh.Text = "&Refresh";
            btnSerialRefresh.UseVisualStyleBackColor = true;
            btnSerialRefresh.Click += btnSerialRefresh_Click;
            // 
            // btnSerialDisconnect
            // 
            btnSerialDisconnect.Location = new Point(165, 3);
            btnSerialDisconnect.Name = "btnSerialDisconnect";
            btnSerialDisconnect.Size = new Size(75, 23);
            btnSerialDisconnect.TabIndex = 4;
            btnSerialDisconnect.Text = "&Disconnect";
            btnSerialDisconnect.UseVisualStyleBackColor = true;
            // 
            // lstSerialPorts
            // 
            lstSerialPorts.Dock = DockStyle.Fill;
            lstSerialPorts.FormattingEnabled = true;
            lstSerialPorts.ItemHeight = 15;
            lstSerialPorts.Location = new Point(3, 19);
            lstSerialPorts.Name = "lstSerialPorts";
            lstSerialPorts.Size = new Size(780, 561);
            lstSerialPorts.TabIndex = 0;
            // 
            // tabLog
            // 
            tabLog.Controls.Add(groupBox1);
            tabLog.Location = new Point(4, 24);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(3);
            tabLog.Size = new Size(792, 589);
            tabLog.TabIndex = 2;
            tabLog.Text = "Messages";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLog);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 583);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log:";
            // 
            // lstLog
            // 
            lstLog.Dock = DockStyle.Fill;
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(3, 19);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(780, 561);
            lstLog.TabIndex = 0;
            // 
            // MicroBitOrchestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 641);
            Controls.Add(tabControls);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "MicroBitOrchestra";
            Text = "Midi Microbit Orchestra";
            Load += MicroBitOrchestra_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            tabControls.ResumeLayout(false);
            tabMidiOutputDevices.ResumeLayout(false);
            grpMidiOutput.ResumeLayout(false);
            flowMidiOutputButtons.ResumeLayout(false);
            flowMidiOutputButtons.PerformLayout();
            tabSerialPort.ResumeLayout(false);
            grpSerialPorts.ResumeLayout(false);
            flowSerialButtons.ResumeLayout(false);
            tabLog.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private TabControl tabControls;
        private TabPage tabMidiOutputDevices;
        private GroupBox grpMidiOutput;
        private FlowLayoutPanel flowMidiOutputButtons;
        private Button btnMidiOutConnect;
        private Button btnMidiRefresh;
        private Button btnMidiTest;
        private TextBox txtNoteNumber;
        private Button btnStop;
        private ListBox lstMidiOutputDevices;
        private TabPage tabSerialPort;
        private GroupBox grpSerialPorts;
        private FlowLayoutPanel flowSerialButtons;
        private Button btnSerialConnect;
        private Button btnSerialRefresh;
        private Button btnSerialDisconnect;
        private ListBox lstSerialPorts;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TabPage tabLog;
        private GroupBox groupBox1;
        private ListBox lstLog;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
    }
}
