namespace Graphics_Task1
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
            this.CoalRadio = new System.Windows.Forms.RadioButton();
            this.SandRadio = new System.Windows.Forms.RadioButton();
            this.WoodRadio = new System.Windows.Forms.RadioButton();
            this.TrainRadio = new System.Windows.Forms.RadioButton();
            this.nudCartsCount = new System.Windows.Forms.NumericUpDown();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCartsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // CoalRadio
            // 
            this.CoalRadio.AutoSize = true;
            this.CoalRadio.Location = new System.Drawing.Point(9, 12);
            this.CoalRadio.Name = "CoalRadio";
            this.CoalRadio.Size = new System.Drawing.Size(57, 21);
            this.CoalRadio.TabIndex = 0;
            this.CoalRadio.Text = "Coal";
            this.CoalRadio.UseVisualStyleBackColor = true;
            // 
            // SandRadio
            // 
            this.SandRadio.AutoSize = true;
            this.SandRadio.Location = new System.Drawing.Point(81, 12);
            this.SandRadio.Name = "SandRadio";
            this.SandRadio.Size = new System.Drawing.Size(62, 21);
            this.SandRadio.TabIndex = 1;
            this.SandRadio.Text = "Sand";
            this.SandRadio.UseVisualStyleBackColor = true;
            // 
            // WoodRadio
            // 
            this.WoodRadio.AutoSize = true;
            this.WoodRadio.Location = new System.Drawing.Point(153, 12);
            this.WoodRadio.Name = "WoodRadio";
            this.WoodRadio.Size = new System.Drawing.Size(66, 21);
            this.WoodRadio.TabIndex = 2;
            this.WoodRadio.Text = "Wood";
            this.WoodRadio.UseVisualStyleBackColor = true;
            // 
            // TrainRadio
            // 
            this.TrainRadio.AutoSize = true;
            this.TrainRadio.Checked = true;
            this.TrainRadio.Location = new System.Drawing.Point(288, 11);
            this.TrainRadio.Name = "TrainRadio";
            this.TrainRadio.Size = new System.Drawing.Size(62, 21);
            this.TrainRadio.TabIndex = 3;
            this.TrainRadio.TabStop = true;
            this.TrainRadio.Text = "Train";
            this.TrainRadio.UseVisualStyleBackColor = true;
            // 
            // nudCartsCount
            // 
            this.nudCartsCount.Location = new System.Drawing.Point(225, 11);
            this.nudCartsCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCartsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCartsCount.Name = "nudCartsCount";
            this.nudCartsCount.Size = new System.Drawing.Size(57, 22);
            this.nudCartsCount.TabIndex = 4;
            this.nudCartsCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(368, 12);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(75, 23);
            this.btLeft.TabIndex = 5;
            this.btLeft.Text = "<-";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(449, 12);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(75, 23);
            this.btRight.TabIndex = 6;
            this.btRight.Text = "->";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.nudCartsCount);
            this.Controls.Add(this.TrainRadio);
            this.Controls.Add(this.WoodRadio);
            this.Controls.Add(this.SandRadio);
            this.Controls.Add(this.CoalRadio);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudCartsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CoalRadio;
        private System.Windows.Forms.RadioButton SandRadio;
        private System.Windows.Forms.RadioButton WoodRadio;
        private System.Windows.Forms.RadioButton TrainRadio;
        private System.Windows.Forms.NumericUpDown nudCartsCount;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Label label1;
    }
}

