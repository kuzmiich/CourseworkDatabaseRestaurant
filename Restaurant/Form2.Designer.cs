using System;

namespace Restaurant
{
    partial class Form2
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
            this.list1 = new System.Windows.Forms.ListBox();
            this.btFill = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.btManualFilling = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 20;
            this.list1.Location = new System.Drawing.Point(41, 55);
            this.list1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(440, 164);
            this.list1.TabIndex = 0;
            // 
            // btFill
            // 
            this.btFill.Location = new System.Drawing.Point(511, 55);
            this.btFill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFill.Name = "btFill";
            this.btFill.Size = new System.Drawing.Size(111, 35);
            this.btFill.TabIndex = 1;
            this.btFill.Text = "Fill from DB";
            this.btFill.UseVisualStyleBackColor = true;
            this.btFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(511, 184);
            this.btClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(111, 35);
            this.btClean.TabIndex = 2;
            this.btClean.Text = "Clean";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btManualFilling
            // 
            this.btManualFilling.Location = new System.Drawing.Point(511, 119);
            this.btManualFilling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btManualFilling.Name = "btManualFilling";
            this.btManualFilling.Size = new System.Drawing.Size(111, 35);
            this.btManualFilling.TabIndex = 3;
            this.btManualFilling.Text = "Manual Filling";
            this.btManualFilling.UseVisualStyleBackColor = true;
            this.btManualFilling.Click += new System.EventHandler(this.btnManualFilling_Click);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(184, 334);
            this.btChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(297, 58);
            this.btChange.TabIndex = 4;
            this.btChange.Text = "Add";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(184, 274);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(151, 27);
            this.tbName.TabIndex = 6;
            this.tbName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manufacturer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Good Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Count";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(497, 274);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 27);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(344, 274);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(137, 27);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(41, 274);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(136, 27);
            this.numericUpDown3.TabIndex = 14;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Товар | производителе | Цена | Количество";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btManualFilling);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btFill);
            this.Controls.Add(this.list1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Button btFill;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btManualFilling;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
    }
}

