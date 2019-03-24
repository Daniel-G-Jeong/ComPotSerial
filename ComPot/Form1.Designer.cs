namespace Mbed_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConnectPage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Connect = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_DevSPort = new System.Windows.Forms.ComboBox();
            this.btnDevConnect = new System.Windows.Forms.Button();
            this.btnDevUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxDevPrefName = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel_DevStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_DevConnected = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_DevSPortRate = new System.Windows.Forms.ComboBox();
            this.combo_DevSPortDataBit = new System.Windows.Forms.ComboBox();
            this.combo_DevSPortStopBit = new System.Windows.Forms.ComboBox();
            this.combo_DevSPortParity = new System.Windows.Forms.ComboBox();
            this.combo_DevSPortHandShaking = new System.Windows.Forms.ComboBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_DevSendData = new System.Windows.Forms.TextBox();
            this.btnDevSend = new System.Windows.Forms.Button();
            this.rtbDevLog = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutPanel_DevStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDataFileToolStripMenuItem
            // 
            this.loadDataFileToolStripMenuItem.Name = "loadDataFileToolStripMenuItem";
            this.loadDataFileToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadDataFileToolStripMenuItem.Text = "Load Data File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 733);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1237, 709);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnConnectPage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 709);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnConnectPage
            // 
            this.btnConnectPage.Location = new System.Drawing.Point(3, 3);
            this.btnConnectPage.Name = "btnConnectPage";
            this.btnConnectPage.Size = new System.Drawing.Size(145, 30);
            this.btnConnectPage.TabIndex = 0;
            this.btnConnectPage.Text = "Device Connection";
            this.btnConnectPage.UseVisualStyleBackColor = true;
            this.btnConnectPage.Click += new System.EventHandler(this.btnLMenuConnect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Connect);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 709);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Connect
            // 
            this.tabPage_Connect.Controls.Add(this.splitContainer2);
            this.tabPage_Connect.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Connect.Name = "tabPage_Connect";
            this.tabPage_Connect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Connect.Size = new System.Drawing.Size(1050, 683);
            this.tabPage_Connect.TabIndex = 0;
            this.tabPage_Connect.Text = "Connect";
            this.tabPage_Connect.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1044, 677);
            this.splitContainer2.SplitterDistance = 38;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.combo_DevSPort);
            this.flowLayoutPanel2.Controls.Add(this.btnDevConnect);
            this.flowLayoutPanel2.Controls.Add(this.btnDevUpdate);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.tboxDevPrefName);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1044, 38);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port(s)";
            // 
            // combo_DevSPort
            // 
            this.combo_DevSPort.FormattingEnabled = true;
            this.combo_DevSPort.Location = new System.Drawing.Point(75, 5);
            this.combo_DevSPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.combo_DevSPort.Name = "combo_DevSPort";
            this.combo_DevSPort.Size = new System.Drawing.Size(150, 21);
            this.combo_DevSPort.TabIndex = 1;
            // 
            // btnDevConnect
            // 
            this.btnDevConnect.Location = new System.Drawing.Point(231, 3);
            this.btnDevConnect.Name = "btnDevConnect";
            this.btnDevConnect.Size = new System.Drawing.Size(120, 25);
            this.btnDevConnect.TabIndex = 2;
            this.btnDevConnect.Text = "Connect";
            this.btnDevConnect.UseVisualStyleBackColor = true;
            this.btnDevConnect.Click += new System.EventHandler(this.btnDevConnect_Click);
            // 
            // btnDevUpdate
            // 
            this.btnDevUpdate.Location = new System.Drawing.Point(357, 3);
            this.btnDevUpdate.Name = "btnDevUpdate";
            this.btnDevUpdate.Size = new System.Drawing.Size(78, 25);
            this.btnDevUpdate.TabIndex = 3;
            this.btnDevUpdate.Text = "Update";
            this.btnDevUpdate.UseVisualStyleBackColor = true;
            this.btnDevUpdate.Click += new System.EventHandler(this.btnDevUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "       Preffered ";
            // 
            // tboxDevPrefName
            // 
            this.tboxDevPrefName.Location = new System.Drawing.Point(521, 5);
            this.tboxDevPrefName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.tboxDevPrefName.Name = "tboxDevPrefName";
            this.tboxDevPrefName.Size = new System.Drawing.Size(447, 20);
            this.tboxDevPrefName.TabIndex = 5;
            this.tboxDevPrefName.Text = "mbed Serial Port";
            this.tboxDevPrefName.WordWrap = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.flowLayoutPanel_DevStatus);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(1044, 635);
            this.splitContainer3.SplitterDistance = 120;
            this.splitContainer3.TabIndex = 0;
            // 
            // flowLayoutPanel_DevStatus
            // 
            this.flowLayoutPanel_DevStatus.Controls.Add(this.label2);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.label_DevConnected);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.label6);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.combo_DevSPortRate);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.combo_DevSPortDataBit);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.combo_DevSPortStopBit);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.combo_DevSPortParity);
            this.flowLayoutPanel_DevStatus.Controls.Add(this.combo_DevSPortHandShaking);
            this.flowLayoutPanel_DevStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_DevStatus.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_DevStatus.Name = "flowLayoutPanel_DevStatus";
            this.flowLayoutPanel_DevStatus.Size = new System.Drawing.Size(120, 635);
            this.flowLayoutPanel_DevStatus.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // label_DevConnected
            // 
            this.label_DevConnected.AutoSize = true;
            this.label_DevConnected.ForeColor = System.Drawing.Color.Red;
            this.label_DevConnected.Location = new System.Drawing.Point(3, 13);
            this.label_DevConnected.Name = "label_DevConnected";
            this.label_DevConnected.Size = new System.Drawing.Size(79, 13);
            this.label_DevConnected.TabIndex = 3;
            this.label_DevConnected.Text = "Not Connected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Port Config.";
            // 
            // combo_DevSPortRate
            // 
            this.combo_DevSPortRate.FormattingEnabled = true;
            this.combo_DevSPortRate.Location = new System.Drawing.Point(3, 64);
            this.combo_DevSPortRate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.combo_DevSPortRate.Name = "combo_DevSPortRate";
            this.combo_DevSPortRate.Size = new System.Drawing.Size(95, 21);
            this.combo_DevSPortRate.TabIndex = 5;
            // 
            // combo_DevSPortDataBit
            // 
            this.combo_DevSPortDataBit.FormattingEnabled = true;
            this.combo_DevSPortDataBit.Location = new System.Drawing.Point(3, 93);
            this.combo_DevSPortDataBit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.combo_DevSPortDataBit.Name = "combo_DevSPortDataBit";
            this.combo_DevSPortDataBit.Size = new System.Drawing.Size(95, 21);
            this.combo_DevSPortDataBit.TabIndex = 6;
            // 
            // combo_DevSPortStopBit
            // 
            this.combo_DevSPortStopBit.FormattingEnabled = true;
            this.combo_DevSPortStopBit.Location = new System.Drawing.Point(3, 122);
            this.combo_DevSPortStopBit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.combo_DevSPortStopBit.Name = "combo_DevSPortStopBit";
            this.combo_DevSPortStopBit.Size = new System.Drawing.Size(95, 21);
            this.combo_DevSPortStopBit.TabIndex = 7;
            // 
            // combo_DevSPortParity
            // 
            this.combo_DevSPortParity.FormattingEnabled = true;
            this.combo_DevSPortParity.Location = new System.Drawing.Point(3, 151);
            this.combo_DevSPortParity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.combo_DevSPortParity.Name = "combo_DevSPortParity";
            this.combo_DevSPortParity.Size = new System.Drawing.Size(95, 21);
            this.combo_DevSPortParity.TabIndex = 8;
            // 
            // combo_DevSPortHandShaking
            // 
            this.combo_DevSPortHandShaking.FormattingEnabled = true;
            this.combo_DevSPortHandShaking.Location = new System.Drawing.Point(3, 180);
            this.combo_DevSPortHandShaking.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.combo_DevSPortHandShaking.Name = "combo_DevSPortHandShaking";
            this.combo_DevSPortHandShaking.Size = new System.Drawing.Size(95, 21);
            this.combo_DevSPortHandShaking.TabIndex = 9;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.flowLayoutPanel4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.rtbDevLog);
            this.splitContainer4.Size = new System.Drawing.Size(920, 635);
            this.splitContainer4.SplitterDistance = 32;
            this.splitContainer4.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.textBox_DevSendData);
            this.flowLayoutPanel4.Controls.Add(this.btnDevSend);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(920, 32);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // textBox_DevSendData
            // 
            this.textBox_DevSendData.Location = new System.Drawing.Point(3, 5);
            this.textBox_DevSendData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.textBox_DevSendData.Name = "textBox_DevSendData";
            this.textBox_DevSendData.Size = new System.Drawing.Size(447, 20);
            this.textBox_DevSendData.TabIndex = 6;
            this.textBox_DevSendData.WordWrap = false;
            // 
            // btnDevSend
            // 
            this.btnDevSend.Enabled = false;
            this.btnDevSend.Location = new System.Drawing.Point(456, 3);
            this.btnDevSend.Name = "btnDevSend";
            this.btnDevSend.Size = new System.Drawing.Size(78, 25);
            this.btnDevSend.TabIndex = 7;
            this.btnDevSend.Text = "Send";
            this.btnDevSend.UseVisualStyleBackColor = true;
            this.btnDevSend.Click += new System.EventHandler(this.btnDevSend_Click);
            // 
            // rtbDevLog
            // 
            this.rtbDevLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDevLog.Location = new System.Drawing.Point(0, 0);
            this.rtbDevLog.Name = "rtbDevLog";
            this.rtbDevLog.Size = new System.Drawing.Size(920, 599);
            this.rtbDevLog.TabIndex = 0;
            this.rtbDevLog.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 755);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ComPot Serial (v0.0.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Connect.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutPanel_DevStatus.ResumeLayout(false);
            this.flowLayoutPanel_DevStatus.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConnectPage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Connect;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_DevSPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_DevConnected;
        private System.Windows.Forms.Button btnDevConnect;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_DevStatus;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RichTextBox rtbDevLog;
        private System.Windows.Forms.Button btnDevUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxDevPrefName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_DevSPortRate;
        private System.Windows.Forms.ComboBox combo_DevSPortDataBit;
        private System.Windows.Forms.ComboBox combo_DevSPortStopBit;
        private System.Windows.Forms.ComboBox combo_DevSPortParity;
        private System.Windows.Forms.ComboBox combo_DevSPortHandShaking;
        private System.Windows.Forms.TextBox textBox_DevSendData;
        private System.Windows.Forms.Button btnDevSend;
    }
}

