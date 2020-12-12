namespace Server
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
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.gbServerControl = new System.Windows.Forms.GroupBox();
            this.btRefreshIPs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServerIP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.gbConsole = new System.Windows.Forms.GroupBox();
            this._Console = new System.Windows.Forms.RichTextBox();
            this.btConsoleEnter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btConsoleClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbServerIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbServerPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbServerControl.SuspendLayout();
            this.gbConsole.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(4, 17);
            this.btStart.Margin = new System.Windows.Forms.Padding(2);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(56, 19);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(65, 17);
            this.btStop.Margin = new System.Windows.Forms.Padding(2);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(56, 19);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // gbServerControl
            // 
            this.gbServerControl.Controls.Add(this.btRefreshIPs);
            this.gbServerControl.Controls.Add(this.label2);
            this.gbServerControl.Controls.Add(this.cbServerIP);
            this.gbServerControl.Controls.Add(this.label1);
            this.gbServerControl.Controls.Add(this.tbServerPort);
            this.gbServerControl.Controls.Add(this.btStop);
            this.gbServerControl.Controls.Add(this.btStart);
            this.gbServerControl.Location = new System.Drawing.Point(9, 10);
            this.gbServerControl.Margin = new System.Windows.Forms.Padding(2);
            this.gbServerControl.Name = "gbServerControl";
            this.gbServerControl.Padding = new System.Windows.Forms.Padding(2);
            this.gbServerControl.Size = new System.Drawing.Size(130, 125);
            this.gbServerControl.TabIndex = 4;
            this.gbServerControl.TabStop = false;
            this.gbServerControl.Text = "Server Control";
            // 
            // btRefreshIPs
            // 
            this.btRefreshIPs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRefreshIPs.Location = new System.Drawing.Point(100, 101);
            this.btRefreshIPs.Margin = new System.Windows.Forms.Padding(2);
            this.btRefreshIPs.Name = "btRefreshIPs";
            this.btRefreshIPs.Size = new System.Drawing.Size(18, 20);
            this.btRefreshIPs.TabIndex = 8;
            this.btRefreshIPs.Text = "🗘";
            this.btRefreshIPs.UseVisualStyleBackColor = true;
            this.btRefreshIPs.Click += new System.EventHandler(this.btRefreshIPs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Listen IP:";
            // 
            // cbServerIP
            // 
            this.cbServerIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerIP.FormattingEnabled = true;
            this.cbServerIP.Location = new System.Drawing.Point(4, 101);
            this.cbServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.cbServerIP.Name = "cbServerIP";
            this.cbServerIP.Size = new System.Drawing.Size(92, 21);
            this.cbServerIP.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port:";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(4, 59);
            this.tbServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(76, 20);
            this.tbServerPort.TabIndex = 4;
            this.tbServerPort.Text = "59321";
            this.tbServerPort.TextChanged += new System.EventHandler(this.tbServerPort_TextChanged);
            // 
            // gbConsole
            // 
            this.gbConsole.Controls.Add(this._Console);
            this.gbConsole.Controls.Add(this.btConsoleEnter);
            this.gbConsole.Controls.Add(this.textBox1);
            this.gbConsole.Controls.Add(this.btConsoleClear);
            this.gbConsole.Location = new System.Drawing.Point(297, 10);
            this.gbConsole.Margin = new System.Windows.Forms.Padding(2);
            this.gbConsole.Name = "gbConsole";
            this.gbConsole.Padding = new System.Windows.Forms.Padding(2);
            this.gbConsole.Size = new System.Drawing.Size(294, 338);
            this.gbConsole.TabIndex = 5;
            this.gbConsole.TabStop = false;
            this.gbConsole.Text = "Server Console";
            // 
            // _Console
            // 
            this._Console.Location = new System.Drawing.Point(5, 18);
            this._Console.Name = "_Console";
            this._Console.Size = new System.Drawing.Size(284, 290);
            this._Console.TabIndex = 4;
            this._Console.Text = "";
            // 
            // btConsoleEnter
            // 
            this.btConsoleEnter.Location = new System.Drawing.Point(191, 313);
            this.btConsoleEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btConsoleEnter.Name = "btConsoleEnter";
            this.btConsoleEnter.Size = new System.Drawing.Size(38, 19);
            this.btConsoleEnter.TabIndex = 3;
            this.btConsoleEnter.Text = "Enter";
            this.btConsoleEnter.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 313);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btConsoleClear
            // 
            this.btConsoleClear.Location = new System.Drawing.Point(233, 313);
            this.btConsoleClear.Margin = new System.Windows.Forms.Padding(2);
            this.btConsoleClear.Name = "btConsoleClear";
            this.btConsoleClear.Size = new System.Drawing.Size(56, 19);
            this.btConsoleClear.TabIndex = 1;
            this.btConsoleClear.Text = "Clear";
            this.btConsoleClear.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbServerStatus,
            this.lbServerIP,
            this.lbServerPort});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbServerStatus
            // 
            this.lbServerStatus.Name = "lbServerStatus";
            this.lbServerStatus.Size = new System.Drawing.Size(24, 17);
            this.lbServerStatus.Text = "Off";
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
            this.lbServerPort.Size = new System.Drawing.Size(38, 17);
            this.lbServerPort.Text = ":XXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbConsole);
            this.Controls.Add(this.gbServerControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbServerControl.ResumeLayout(false);
            this.gbServerControl.PerformLayout();
            this.gbConsole.ResumeLayout(false);
            this.gbConsole.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.GroupBox gbServerControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.GroupBox gbConsole;
        private System.Windows.Forms.Button btConsoleEnter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btConsoleClear;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbServerStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbServerIP;
        private System.Windows.Forms.ToolStripStatusLabel lbServerPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServerIP;
        private System.Windows.Forms.Button btRefreshIPs;
        private System.Windows.Forms.RichTextBox _Console;
        private System.Windows.Forms.Timer timer1;
    }
}

