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
            grpMidiOutput = new GroupBox();
            flowMidiOutputButtons = new FlowLayoutPanel();
            btnMidiOutConnect = new Button();
            btnMidiRefresh = new Button();
            btnMidiTest = new Button();
            txtNoteNumber = new TextBox();
            lstMidiOutputDevices = new ListBox();
            grpSerialPorts = new GroupBox();
            flowSerialButtons = new FlowLayoutPanel();
            btnSerialConnect = new Button();
            btnSerialRefresh = new Button();
            btnSerialDisconnect = new Button();
            lstSerialPorts = new ListBox();
            tblMain = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            lstLog = new ListBox();
            btnStop = new Button();
            grpMidiOutput.SuspendLayout();
            flowMidiOutputButtons.SuspendLayout();
            grpSerialPorts.SuspendLayout();
            flowSerialButtons.SuspendLayout();
            tblMain.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpMidiOutput
            // 
            grpMidiOutput.Controls.Add(flowMidiOutputButtons);
            grpMidiOutput.Controls.Add(lstMidiOutputDevices);
            grpMidiOutput.Dock = DockStyle.Fill;
            grpMidiOutput.Location = new Point(3, 3);
            grpMidiOutput.Name = "grpMidiOutput";
            grpMidiOutput.Size = new Size(794, 174);
            grpMidiOutput.TabIndex = 0;
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
            flowMidiOutputButtons.Location = new Point(3, 140);
            flowMidiOutputButtons.Name = "flowMidiOutputButtons";
            flowMidiOutputButtons.Size = new Size(788, 31);
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
            btnMidiTest.Size = new Size(75, 23);
            btnMidiTest.TabIndex = 4;
            btnMidiTest.Text = "&Test";
            btnMidiTest.UseVisualStyleBackColor = true;
            btnMidiTest.Click += btnMidiTest_Click;
            // 
            // txtNoteNumber
            // 
            txtNoteNumber.Location = new Point(246, 3);
            txtNoteNumber.Name = "txtNoteNumber";
            txtNoteNumber.Size = new Size(100, 23);
            txtNoteNumber.TabIndex = 5;
            txtNoteNumber.Text = "64";
            // 
            // lstMidiOutputDevices
            // 
            lstMidiOutputDevices.Dock = DockStyle.Fill;
            lstMidiOutputDevices.FormattingEnabled = true;
            lstMidiOutputDevices.ItemHeight = 15;
            lstMidiOutputDevices.Location = new Point(3, 19);
            lstMidiOutputDevices.Name = "lstMidiOutputDevices";
            lstMidiOutputDevices.Size = new Size(788, 152);
            lstMidiOutputDevices.TabIndex = 0;
            // 
            // grpSerialPorts
            // 
            grpSerialPorts.Controls.Add(flowSerialButtons);
            grpSerialPorts.Controls.Add(lstSerialPorts);
            grpSerialPorts.Dock = DockStyle.Fill;
            grpSerialPorts.Location = new Point(3, 183);
            grpSerialPorts.Name = "grpSerialPorts";
            grpSerialPorts.Size = new Size(794, 198);
            grpSerialPorts.TabIndex = 1;
            grpSerialPorts.TabStop = false;
            grpSerialPorts.Text = "Serial Ports:";
            // 
            // flowSerialButtons
            // 
            flowSerialButtons.Controls.Add(btnSerialConnect);
            flowSerialButtons.Controls.Add(btnSerialRefresh);
            flowSerialButtons.Controls.Add(btnSerialDisconnect);
            flowSerialButtons.Dock = DockStyle.Bottom;
            flowSerialButtons.Location = new Point(3, 164);
            flowSerialButtons.Name = "flowSerialButtons";
            flowSerialButtons.Size = new Size(788, 31);
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
            lstSerialPorts.Size = new Size(788, 176);
            lstSerialPorts.TabIndex = 0;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(groupBox1, 0, 2);
            tblMain.Controls.Add(grpMidiOutput, 0, 0);
            tblMain.Controls.Add(grpSerialPorts, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7741928F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 53.2258072F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tblMain.Size = new Size(800, 641);
            tblMain.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstLog);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 387);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 251);
            groupBox1.TabIndex = 3;
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
            lstLog.Size = new Size(788, 229);
            lstLog.TabIndex = 0;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(352, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 6;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // MicroBitOrchestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 641);
            Controls.Add(tblMain);
            Name = "MicroBitOrchestra";
            Text = "Midi Microbit Orchestra";
            Load += MicroBitOrchestra_Load;
            grpMidiOutput.ResumeLayout(false);
            flowMidiOutputButtons.ResumeLayout(false);
            flowMidiOutputButtons.PerformLayout();
            grpSerialPorts.ResumeLayout(false);
            flowSerialButtons.ResumeLayout(false);
            tblMain.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMidiOutput;
        private FlowLayoutPanel flowMidiOutputButtons;
        private ListBox lstMidiOutputDevices;
        private Button btnMidiOutConnect;
        private Button btnMidiRefresh;
        private Button btnMidiTest;
        private GroupBox grpSerialPorts;
        private FlowLayoutPanel flowSerialButtons;
        private Button btnSerialConnect;
        private Button btnSerialRefresh;
        private Button btnSerialDisconnect;
        private ListBox lstSerialPorts;
        private TableLayoutPanel tblMain;
        private GroupBox groupBox1;
        private ListBox lstLog;
        private TextBox txtNoteNumber;
        private Button btnStop;
    }
}
