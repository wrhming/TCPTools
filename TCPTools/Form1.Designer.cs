
namespace TCPTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstClient = new System.Windows.Forms.ListBox();
            this.btnClientStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richServerMsg = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstServerMsg = new System.Windows.Forms.ListBox();
            this.btnServerClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxClientIP = new System.Windows.Forms.TextBox();
            this.tboxClientPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.tboxMsg = new System.Windows.Forms.TextBox();
            this.lstClientMsg = new System.Windows.Forms.ListBox();
            this.btnClearMsg = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstServerMsg);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnServerClear);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.lstClientMsg);
            this.tabPage2.Controls.Add(this.btnClearMsg);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCP Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richServerMsg);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxPort);
            this.groupBox1.Controls.Add(this.tboxIP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // tboxIP
            // 
            this.tboxIP.Location = new System.Drawing.Point(64, 17);
            this.tboxIP.Name = "tboxIP";
            this.tboxIP.Size = new System.Drawing.Size(150, 21);
            this.tboxIP.TabIndex = 0;
            this.tboxIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "主机：";
            // 
            // tboxPort
            // 
            this.tboxPort.Location = new System.Drawing.Point(64, 53);
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(62, 21);
            this.tboxPort.TabIndex = 0;
            this.tboxPort.Text = "6800";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口：";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(132, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(38, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "侦听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(176, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(38, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "结束";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstClient
            // 
            this.lstClient.FormattingEnabled = true;
            this.lstClient.ItemHeight = 12;
            this.lstClient.Location = new System.Drawing.Point(6, 20);
            this.lstClient.Name = "lstClient";
            this.lstClient.Size = new System.Drawing.Size(137, 160);
            this.lstClient.TabIndex = 3;
            // 
            // btnClientStop
            // 
            this.btnClientStop.Location = new System.Drawing.Point(149, 20);
            this.btnClientStop.Name = "btnClientStop";
            this.btnClientStop.Size = new System.Drawing.Size(38, 23);
            this.btnClientStop.TabIndex = 2;
            this.btnClientStop.Text = "断开";
            this.btnClientStop.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstClient);
            this.groupBox2.Controls.Add(this.btnClientStop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(266, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 186);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户端";
            // 
            // richServerMsg
            // 
            this.richServerMsg.Location = new System.Drawing.Point(19, 90);
            this.richServerMsg.Name = "richServerMsg";
            this.richServerMsg.Size = new System.Drawing.Size(151, 96);
            this.richServerMsg.TabIndex = 5;
            this.richServerMsg.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(176, 163);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(38, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstServerMsg
            // 
            this.lstServerMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstServerMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstServerMsg.FormattingEnabled = true;
            this.lstServerMsg.ItemHeight = 12;
            this.lstServerMsg.Location = new System.Drawing.Point(3, 245);
            this.lstServerMsg.Name = "lstServerMsg";
            this.lstServerMsg.Size = new System.Drawing.Size(495, 148);
            this.lstServerMsg.TabIndex = 1;
            // 
            // btnServerClear
            // 
            this.btnServerClear.Location = new System.Drawing.Point(432, 216);
            this.btnServerClear.Name = "btnServerClear";
            this.btnServerClear.Size = new System.Drawing.Size(61, 23);
            this.btnServerClear.TabIndex = 2;
            this.btnServerClear.Text = "清空消息";
            this.btnServerClear.UseVisualStyleBackColor = true;
            this.btnServerClear.Click += new System.EventHandler(this.btnServerClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "主机：";
            // 
            // tboxClientIP
            // 
            this.tboxClientIP.Location = new System.Drawing.Point(52, 20);
            this.tboxClientIP.Name = "tboxClientIP";
            this.tboxClientIP.Size = new System.Drawing.Size(150, 21);
            this.tboxClientIP.TabIndex = 2;
            this.tboxClientIP.Text = "127.0.0.1";
            // 
            // tboxClientPort
            // 
            this.tboxClientPort.Location = new System.Drawing.Point(225, 20);
            this.tboxClientPort.Name = "tboxClientPort";
            this.tboxClientPort.Size = new System.Drawing.Size(35, 21);
            this.tboxClientPort.TabIndex = 2;
            this.tboxClientPort.Text = "6800";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(321, 18);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(38, 23);
            this.btnDisConnect.TabIndex = 5;
            this.btnDisConnect.Text = "断开";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(277, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(38, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClientSend
            // 
            this.btnClientSend.Location = new System.Drawing.Point(419, 53);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(38, 23);
            this.btnClientSend.TabIndex = 7;
            this.btnClientSend.Text = "发送";
            this.btnClientSend.UseVisualStyleBackColor = true;
            this.btnClientSend.Click += new System.EventHandler(this.btnClientSend_Click);
            // 
            // tboxMsg
            // 
            this.tboxMsg.Location = new System.Drawing.Point(7, 53);
            this.tboxMsg.Name = "tboxMsg";
            this.tboxMsg.Size = new System.Drawing.Size(397, 21);
            this.tboxMsg.TabIndex = 8;
            // 
            // lstClientMsg
            // 
            this.lstClientMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstClientMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstClientMsg.FormattingEnabled = true;
            this.lstClientMsg.ItemHeight = 12;
            this.lstClientMsg.Location = new System.Drawing.Point(3, 137);
            this.lstClientMsg.Name = "lstClientMsg";
            this.lstClientMsg.Size = new System.Drawing.Size(495, 256);
            this.lstClientMsg.TabIndex = 9;
            // 
            // btnClearMsg
            // 
            this.btnClearMsg.Location = new System.Drawing.Point(432, 110);
            this.btnClearMsg.Name = "btnClearMsg";
            this.btnClearMsg.Size = new System.Drawing.Size(61, 23);
            this.btnClearMsg.TabIndex = 10;
            this.btnClearMsg.Text = "清空消息";
            this.btnClearMsg.UseVisualStyleBackColor = true;
            this.btnClearMsg.Click += new System.EventHandler(this.btnClearMsg_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tboxClientIP);
            this.groupBox3.Controls.Add(this.tboxClientPort);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tboxMsg);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnClientSend);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.btnDisConnect);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 101);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "选项";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstClient;
        private System.Windows.Forms.Button btnClientStop;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPort;
        private System.Windows.Forms.TextBox tboxIP;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstServerMsg;
        private System.Windows.Forms.RichTextBox richServerMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnServerClear;
        private System.Windows.Forms.ListBox lstClientMsg;
        private System.Windows.Forms.Button btnClearMsg;
        private System.Windows.Forms.TextBox tboxMsg;
        private System.Windows.Forms.Button btnClientSend;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxClientPort;
        private System.Windows.Forms.TextBox tboxClientIP;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

