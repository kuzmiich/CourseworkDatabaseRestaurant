using System;

namespace Lab2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.manufacturerId = new System.Windows.Forms.TextBox();
            this.goodsName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(45, 62);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 184);
            this.listBox1.TabIndex = 0;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(436, 62);
            this.btRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(100, 35);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(436, 138);
            this.btClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(100, 35);
            this.btClean.TabIndex = 2;
            this.btClean.Text = "Очистить";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btSum
            // 
            this.btSum.Location = new System.Drawing.Point(436, 211);
            this.btSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(100, 35);
            this.btSum.TabIndex = 3;
            this.btSum.Text = "Всего";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.BtnGetCount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Товар | производителе | Цена | Количество";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(236, 394);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID производителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Название товара";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 303);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Цена товара";
            // 
            // manufacturerId
            // 
            this.manufacturerId.Location = new System.Drawing.Point(44, 344);
            this.manufacturerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manufacturerId.Name = "manufacturerId";
            this.manufacturerId.Size = new System.Drawing.Size(132, 27);
            this.manufacturerId.TabIndex = 12;
            // 
            // goodsName
            // 
            this.goodsName.Location = new System.Drawing.Point(184, 344);
            this.goodsName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goodsName.Name = "goodsName";
            this.goodsName.Size = new System.Drawing.Size(132, 27);
            this.goodsName.TabIndex = 13;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(324, 344);
            this.price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(97, 27);
            this.price.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Количество всех товаров: 0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Новому товару присвоен ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Добавлена запись";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Количество";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(436, 344);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 27);
            this.count.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 502);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.goodsName);
            this.Controls.Add(this.manufacturerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.btClean);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Список товаров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox manufacturerId;
        private System.Windows.Forms.TextBox goodsName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox count;
    }
}

