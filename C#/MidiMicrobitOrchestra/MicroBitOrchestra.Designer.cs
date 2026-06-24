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
            components = new System.ComponentModel.Container();
            menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadRulesToolStripMenuItem = new ToolStripMenuItem();
            saveRulesToolStripMenuItem = new ToolStripMenuItem();
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
            comboChannel = new ComboBox();
            lstMidiOutputDevices = new ListBox();
            tabSerialPort = new TabPage();
            grpSerialPorts = new GroupBox();
            flowSerialButtons = new FlowLayoutPanel();
            btnSerialConnect = new Button();
            btnSerialRefresh = new Button();
            btnSerialDisconnect = new Button();
            lstSerialPorts = new ListBox();
            tabLog = new TabPage();
            splitContainer2 = new SplitContainer();
            groupBox1 = new GroupBox();
            lstLog = new ListBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnClear = new Button();
            btnLargerText = new Button();
            btnSmallerText = new Button();
            tabFilter = new TabPage();
            splitContainer3 = new SplitContainer();
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            txtRuleEditor = new TextBox();
            groupBox4 = new GroupBox();
            lstRules = new ListBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtTestMessage = new TextBox();
            btnTest = new Button();
            statusStrip1 = new StatusStrip();
            lblRules = new ToolStripStatusLabel();
            ruleUpdateTimer = new System.Windows.Forms.Timer(components);
            menu.SuspendLayout();
            tabControls.SuspendLayout();
            tabMidiOutputDevices.SuspendLayout();
            grpMidiOutput.SuspendLayout();
            flowMidiOutputButtons.SuspendLayout();
            tabSerialPort.SuspendLayout();
            grpSerialPorts.SuspendLayout();
            flowSerialButtons.SuspendLayout();
            tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tabFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadRulesToolStripMenuItem, saveRulesToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // loadRulesToolStripMenuItem
            // 
            loadRulesToolStripMenuItem.Name = "loadRulesToolStripMenuItem";
            loadRulesToolStripMenuItem.Size = new Size(128, 22);
            loadRulesToolStripMenuItem.Text = "&Load rules";
            loadRulesToolStripMenuItem.Click += loadRulesToolStripMenuItem_Click;
            // 
            // saveRulesToolStripMenuItem
            // 
            saveRulesToolStripMenuItem.Name = "saveRulesToolStripMenuItem";
            saveRulesToolStripMenuItem.Size = new Size(128, 22);
            saveRulesToolStripMenuItem.Text = "&Save rules";
            saveRulesToolStripMenuItem.Click += saveRulesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(128, 22);
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
            clearToolStripMenuItem.Size = new Size(107, 22);
            clearToolStripMenuItem.Text = "&Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(107, 22);
            exportToolStripMenuItem.Text = "&Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // tabControls
            // 
            tabControls.Controls.Add(tabMidiOutputDevices);
            tabControls.Controls.Add(tabSerialPort);
            tabControls.Controls.Add(tabLog);
            tabControls.Controls.Add(tabFilter);
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
            flowMidiOutputButtons.Controls.Add(comboChannel);
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
            // comboChannel
            // 
            comboChannel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChannel.FormattingEnabled = true;
            comboChannel.Items.AddRange(new object[] { "Channel 1 (instrument)", "Channel 10 (percussion)", "Auto select (from microbit message)" });
            comboChannel.Location = new Point(474, 3);
            comboChannel.Name = "comboChannel";
            comboChannel.Size = new Size(280, 23);
            comboChannel.TabIndex = 7;
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
            tabLog.Controls.Add(splitContainer2);
            tabLog.Location = new Point(4, 24);
            tabLog.Name = "tabLog";
            tabLog.Padding = new Padding(3);
            tabLog.Size = new Size(792, 589);
            tabLog.TabIndex = 2;
            tabLog.Text = "Messages";
            tabLog.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer2.Size = new Size(786, 583);
            splitContainer2.SplitterDistance = 537;
            splitContainer2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLog);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(786, 537);
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
            lstLog.Size = new Size(780, 515);
            lstLog.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnClear);
            flowLayoutPanel2.Controls.Add(btnLargerText);
            flowLayoutPanel2.Controls.Add(btnSmallerText);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(786, 42);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLargerText
            // 
            btnLargerText.Location = new Point(84, 3);
            btnLargerText.Name = "btnLargerText";
            btnLargerText.Size = new Size(75, 23);
            btnLargerText.TabIndex = 1;
            btnLargerText.Text = "+";
            btnLargerText.UseVisualStyleBackColor = true;
            btnLargerText.Click += btnLargerText_Click;
            // 
            // btnSmallerText
            // 
            btnSmallerText.Location = new Point(165, 3);
            btnSmallerText.Name = "btnSmallerText";
            btnSmallerText.Size = new Size(75, 23);
            btnSmallerText.TabIndex = 2;
            btnSmallerText.Text = "-";
            btnSmallerText.UseVisualStyleBackColor = true;
            btnSmallerText.Click += btnSmallerText_Click;
            // 
            // tabFilter
            // 
            tabFilter.Controls.Add(splitContainer3);
            tabFilter.Controls.Add(statusStrip1);
            tabFilter.Location = new Point(4, 24);
            tabFilter.Name = "tabFilter";
            tabFilter.Padding = new Padding(3);
            tabFilter.Size = new Size(792, 589);
            tabFilter.TabIndex = 3;
            tabFilter.Text = "Rules";
            tabFilter.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(groupBox2);
            splitContainer3.Size = new Size(786, 561);
            splitContainer3.SplitterDistance = 449;
            splitContainer3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox4);
            splitContainer1.Size = new Size(786, 449);
            splitContainer1.SplitterDistance = 383;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtRuleEditor);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 449);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rule Editor";
            // 
            // txtRuleEditor
            // 
            txtRuleEditor.Dock = DockStyle.Fill;
            txtRuleEditor.Location = new Point(3, 19);
            txtRuleEditor.Multiline = true;
            txtRuleEditor.Name = "txtRuleEditor";
            txtRuleEditor.Size = new Size(377, 427);
            txtRuleEditor.TabIndex = 0;
            txtRuleEditor.TextChanged += txtRuleEditor_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstRules);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(399, 449);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Valid rules:";
            // 
            // lstRules
            // 
            lstRules.Dock = DockStyle.Fill;
            lstRules.FormattingEnabled = true;
            lstRules.ItemHeight = 15;
            lstRules.Location = new Point(3, 19);
            lstRules.Name = "lstRules";
            lstRules.Size = new Size(393, 427);
            lstRules.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(786, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Test:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtTestMessage);
            flowLayoutPanel1.Controls.Add(btnTest);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(780, 86);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Message:";
            // 
            // txtTestMessage
            // 
            txtTestMessage.Location = new Point(65, 3);
            txtTestMessage.Name = "txtTestMessage";
            txtTestMessage.Size = new Size(456, 23);
            txtTestMessage.TabIndex = 0;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(527, 3);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 1;
            btnTest.Text = "&Test";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblRules });
            statusStrip1.Location = new Point(3, 564);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(786, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblRules
            // 
            lblRules.Name = "lblRules";
            lblRules.Size = new Size(105, 17);
            lblRules.Text = "No errors detected";
            // 
            // ruleUpdateTimer
            // 
            ruleUpdateTimer.Interval = 1000;
            ruleUpdateTimer.Tick += ruleUpdateTimer_Tick;
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
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tabFilter.ResumeLayout(false);
            tabFilter.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private TabPage tabFilter;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem loadRulesToolStripMenuItem;
        private ToolStripMenuItem saveRulesToolStripMenuItem;
        private SplitContainer splitContainer1;
        private TextBox txtRuleEditor;
        private ListBox lstRules;
        private ToolStripStatusLabel lblRules;
        private System.Windows.Forms.Timer ruleUpdateTimer;
        private SplitContainer splitContainer2;
        private ListBox lstLog;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private SplitContainer splitContainer3;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtTestMessage;
        private Button btnTest;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnClear;
        private Button btnLargerText;
        private Button btnSmallerText;
        private ComboBox comboChannel;
    }
}
