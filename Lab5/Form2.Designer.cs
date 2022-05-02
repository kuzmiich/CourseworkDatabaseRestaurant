
namespace Lab5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Read = new System.Windows.Forms.Button();
            this.cb_Filter1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Filter2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(482, 231);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_Read
            // 
            this.bt_Read.Location = new System.Drawing.Point(574, 593);
            this.bt_Read.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Read.Name = "bt_Read";
            this.bt_Read.Size = new System.Drawing.Size(202, 35);
            this.bt_Read.TabIndex = 2;
            this.bt_Read.Text = "Read";
            this.bt_Read.UseVisualStyleBackColor = true;
            this.bt_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // cb_Filter1
            // 
            this.cb_Filter1.FormattingEnabled = true;
            this.cb_Filter1.Items.AddRange(new object[] {
            "Фильтрация по производителю",
            "Нет",
            "Фильтрация по цене",
            "Нет"});
            this.cb_Filter1.Location = new System.Drawing.Point(574, 425);
            this.cb_Filter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Filter1.Name = "cb_Filter1";
            this.cb_Filter1.Size = new System.Drawing.Size(202, 28);
            this.cb_Filter1.TabIndex = 4;
            this.cb_Filter1.Text = "Нет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // cb_Filter2
            // 
            this.cb_Filter2.FormattingEnabled = true;
            this.cb_Filter2.Location = new System.Drawing.Point(574, 504);
            this.cb_Filter2.Name = "cb_Filter2";
            this.cb_Filter2.Size = new System.Drawing.Size(202, 28);
            this.cb_Filter2.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 657);
            this.Controls.Add(this.cb_Filter2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Filter1);
            this.Controls.Add(this.bt_Read);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Lab5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Read;
        private System.Windows.Forms.ComboBox cb_Filter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Filter2;
    }
}