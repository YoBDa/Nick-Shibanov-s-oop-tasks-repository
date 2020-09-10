namespace First_lesson_app
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
            this.tbNumerator1 = new System.Windows.Forms.TextBox();
            this.tbDenominator1 = new System.Windows.Forms.TextBox();
            this.tbDenominator2 = new System.Windows.Forms.TextBox();
            this.tbNumerator2 = new System.Windows.Forms.TextBox();
            this.tbDenominator3 = new System.Windows.Forms.TextBox();
            this.tbNumerator3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNumerator1
            // 
            this.tbNumerator1.Location = new System.Drawing.Point(12, 13);
            this.tbNumerator1.Name = "tbNumerator1";
            this.tbNumerator1.Size = new System.Drawing.Size(38, 23);
            this.tbNumerator1.TabIndex = 0;
            // 
            // tbDenominator1
            // 
            this.tbDenominator1.Location = new System.Drawing.Point(12, 52);
            this.tbDenominator1.Name = "tbDenominator1";
            this.tbDenominator1.Size = new System.Drawing.Size(38, 23);
            this.tbDenominator1.TabIndex = 1;
            // 
            // tbDenominator2
            // 
            this.tbDenominator2.Location = new System.Drawing.Point(133, 52);
            this.tbDenominator2.Name = "tbDenominator2";
            this.tbDenominator2.Size = new System.Drawing.Size(38, 23);
            this.tbDenominator2.TabIndex = 3;
            // 
            // tbNumerator2
            // 
            this.tbNumerator2.Location = new System.Drawing.Point(133, 13);
            this.tbNumerator2.Name = "tbNumerator2";
            this.tbNumerator2.Size = new System.Drawing.Size(38, 23);
            this.tbNumerator2.TabIndex = 2;
            // 
            // tbDenominator3
            // 
            this.tbDenominator3.Location = new System.Drawing.Point(232, 52);
            this.tbDenominator3.Name = "tbDenominator3";
            this.tbDenominator3.Size = new System.Drawing.Size(38, 23);
            this.tbDenominator3.TabIndex = 5;
            // 
            // tbNumerator3
            // 
            this.tbNumerator3.Location = new System.Drawing.Point(232, 13);
            this.tbNumerator3.Name = "tbNumerator3";
            this.tbNumerator3.Size = new System.Drawing.Size(38, 23);
            this.tbNumerator3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(102, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(185, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDenominator3);
            this.Controls.Add(this.tbNumerator3);
            this.Controls.Add(this.tbDenominator2);
            this.Controls.Add(this.tbNumerator2);
            this.Controls.Add(this.tbDenominator1);
            this.Controls.Add(this.tbNumerator1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calccccc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumerator1;
        private System.Windows.Forms.TextBox tbDenominator1;
        private System.Windows.Forms.TextBox tbDenominator2;
        private System.Windows.Forms.TextBox tbNumerator2;
        private System.Windows.Forms.TextBox tbDenominator3;
        private System.Windows.Forms.TextBox tbNumerator3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

