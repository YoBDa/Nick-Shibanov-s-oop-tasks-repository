
namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.gbChat = new System.Windows.Forms.GroupBox();
            this.btChatSend = new System.Windows.Forms.Button();
            this.tbWritingArea = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbServerIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbServerPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbChat = new System.Windows.Forms.RichTextBox();
            this.gbOptions.SuspendLayout();
            this.gbChat.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(9, 37);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(100, 20);
            this.tbServerIP.TabIndex = 0;
            this.tbServerIP.Text = "192.168.42.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(115, 37);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(47, 20);
            this.tbServerPort.TabIndex = 2;
            this.tbServerPort.Text = "59321";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btDisconnect);
            this.gbOptions.Controls.Add(this.tbUsername);
            this.gbOptions.Controls.Add(this.label3);
            this.gbOptions.Controls.Add(this.btConnect);
            this.gbOptions.Controls.Add(this.tbServerIP);
            this.gbOptions.Controls.Add(this.label2);
            this.gbOptions.Controls.Add(this.label1);
            this.gbOptions.Controls.Add(this.tbServerPort);
            this.gbOptions.Location = new System.Drawing.Point(12, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(200, 167);
            this.gbOptions.TabIndex = 4;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Connection Options";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(115, 102);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(79, 23);
            this.btDisconnect.TabIndex = 7;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(9, 76);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.Text = "Kwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(0, 102);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(79, 23);
            this.btConnect.TabIndex = 4;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // gbChat
            // 
            this.gbChat.Controls.Add(this.tbChat);
            this.gbChat.Controls.Add(this.btChatSend);
            this.gbChat.Controls.Add(this.tbWritingArea);
            this.gbChat.Location = new System.Drawing.Point(217, 12);
            this.gbChat.Margin = new System.Windows.Forms.Padding(2);
            this.gbChat.Name = "gbChat";
            this.gbChat.Padding = new System.Windows.Forms.Padding(2);
            this.gbChat.Size = new System.Drawing.Size(572, 374);
            this.gbChat.TabIndex = 6;
            this.gbChat.TabStop = false;
            this.gbChat.Text = "Chat";
            // 
            // btChatSend
            // 
            this.btChatSend.Location = new System.Drawing.Point(524, 348);
            this.btChatSend.Margin = new System.Windows.Forms.Padding(2);
            this.btChatSend.Name = "btChatSend";
            this.btChatSend.Size = new System.Drawing.Size(44, 19);
            this.btChatSend.TabIndex = 3;
            this.btChatSend.Text = "Send";
            this.btChatSend.UseVisualStyleBackColor = true;
            this.btChatSend.Click += new System.EventHandler(this.btChatSend_Click);
            // 
            // tbWritingArea
            // 
            this.tbWritingArea.Location = new System.Drawing.Point(4, 257);
            this.tbWritingArea.Margin = new System.Windows.Forms.Padding(2);
            this.tbWritingArea.Multiline = true;
            this.tbWritingArea.Name = "tbWritingArea";
            this.tbWritingArea.Size = new System.Drawing.Size(564, 87);
            this.tbWritingArea.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.lbServerIP,
            this.lbServerPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(43, 17);
            this.lbStatus.Text = "Offline";
            // 
            // lbServerIP
            // 
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(100, 17);
            this.lbServerIP.Text = "XXX.XXX.XXX.XXX";
            // 
            // lbServerPort
            // 
            this.lbServerPort.Name = "lbServerPort";
            this.lbServerPort.Size = new System.Drawing.Size(28, 17);
            this.lbServerPort.Text = "XXX";
            // 
            // tbChat
            // 
            this.tbChat.Location = new System.Drawing.Point(5, 18);
            this.tbChat.Name = "tbChat";
            this.tbChat.ReadOnly = true;
            this.tbChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbChat.Size = new System.Drawing.Size(562, 234);
            this.tbChat.TabIndex = 4;
            this.tbChat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbChat);
            this.Controls.Add(this.gbOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbChat.ResumeLayout(false);
            this.gbChat.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.GroupBox gbChat;
        private System.Windows.Forms.Button btChatSend;
        private System.Windows.Forms.TextBox tbWritingArea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbServerIP;
        private System.Windows.Forms.ToolStripStatusLabel lbServerPort;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox tbChat;
    }
}

