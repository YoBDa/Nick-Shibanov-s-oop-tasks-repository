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
            this.nudCartsCount = new System.Windows.Forms.NumericUpDown();
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.cbShapes = new System.Windows.Forms.ComboBox();
            this.cbCarriages = new System.Windows.Forms.ComboBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCartsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCartsCount
            // 
            this.nudCartsCount.Location = new System.Drawing.Point(136, 214);
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
            this.btLeft.Location = new System.Drawing.Point(26, 39);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(46, 46);
            this.btLeft.TabIndex = 5;
            this.btLeft.Text = "🡐";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.Move_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(130, 39);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(46, 46);
            this.btRight.TabIndex = 6;
            this.btRight.Text = "🡒";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.Move_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(9, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 116);
            this.listBox1.TabIndex = 8;
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(78, 39);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(46, 21);
            this.btUp.TabIndex = 9;
            this.btUp.Text = "🡑";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.Move_Click);
            // 
            // btDown
            // 
            this.btDown.Location = new System.Drawing.Point(77, 64);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(46, 21);
            this.btDown.TabIndex = 10;
            this.btDown.Text = "🡓";
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.Move_Click);
            // 
            // cbShapes
            // 
            this.cbShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShapes.FormattingEnabled = true;
            this.cbShapes.Location = new System.Drawing.Point(9, 9);
            this.cbShapes.Name = "cbShapes";
            this.cbShapes.Size = new System.Drawing.Size(184, 24);
            this.cbShapes.TabIndex = 11;
            this.cbShapes.SelectedIndexChanged += new System.EventHandler(this.cbShapes_SelectedIndexChanged);
            // 
            // cbCarriages
            // 
            this.cbCarriages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarriages.FormattingEnabled = true;
            this.cbCarriages.Location = new System.Drawing.Point(12, 212);
            this.cbCarriages.Name = "cbCarriages";
            this.cbCarriages.Size = new System.Drawing.Size(121, 24);
            this.cbCarriages.TabIndex = 12;
            this.cbCarriages.SelectedIndexChanged += new System.EventHandler(this.cbCarriages_SelectedIndexChanged);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(12, 242);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 13;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(118, 242);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 506);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.cbCarriages);
            this.Controls.Add(this.cbShapes);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Controls.Add(this.nudCartsCount);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.nudCartsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudCartsCount;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.ComboBox cbShapes;
        private System.Windows.Forms.ComboBox cbCarriages;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
    }
}

