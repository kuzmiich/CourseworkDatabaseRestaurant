
namespace Restaurant
{
    partial class GoodsLogsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label goodsIdLabel;
            System.Windows.Forms.Label providerIdLabel;
            System.Windows.Forms.Label deliveryIdLabel;
            System.Windows.Forms.Label dateOfRegistrationLabel;
            this._Restaurant_DatabaseDataSet = new Restaurant._Restaurant_DatabaseDataSet();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.goodsLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.ProvidersTableAdapter();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.GoodsTableAdapter();
            this.restaurantDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.goodsLogsTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.GoodsLogsTableAdapter();
            this.deliveryTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.DeliveryTableAdapter();
            this.restaurantViewTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.RestaurantViewTableAdapter();
            this.restaurantViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.restaurantViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dateOfRegistrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            goodsIdLabel = new System.Windows.Forms.Label();
            providerIdLabel = new System.Windows.Forms.Label();
            deliveryIdLabel = new System.Windows.Forms.Label();
            dateOfRegistrationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._Restaurant_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsIdLabel
            // 
            goodsIdLabel.AutoSize = true;
            goodsIdLabel.Location = new System.Drawing.Point(16, 19);
            goodsIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            goodsIdLabel.Name = "goodsIdLabel";
            goodsIdLabel.Size = new System.Drawing.Size(95, 17);
            goodsIdLabel.TabIndex = 1;
            goodsIdLabel.Text = "Goods Name:";
            // 
            // providerIdLabel
            // 
            providerIdLabel.AutoSize = true;
            providerIdLabel.Location = new System.Drawing.Point(16, 61);
            providerIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            providerIdLabel.Name = "providerIdLabel";
            providerIdLabel.Size = new System.Drawing.Size(106, 17);
            providerIdLabel.TabIndex = 3;
            providerIdLabel.Text = "Provider Name:";
            // 
            // deliveryIdLabel
            // 
            deliveryIdLabel.AutoSize = true;
            deliveryIdLabel.Location = new System.Drawing.Point(18, 104);
            deliveryIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            deliveryIdLabel.Name = "deliveryIdLabel";
            deliveryIdLabel.Size = new System.Drawing.Size(104, 17);
            deliveryIdLabel.TabIndex = 5;
            deliveryIdLabel.Text = "Delivery Name:";
            // 
            // dateOfRegistrationLabel
            // 
            dateOfRegistrationLabel.AutoSize = true;
            dateOfRegistrationLabel.Location = new System.Drawing.Point(16, 153);
            dateOfRegistrationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateOfRegistrationLabel.Name = "dateOfRegistrationLabel";
            dateOfRegistrationLabel.Size = new System.Drawing.Size(141, 17);
            dateOfRegistrationLabel.TabIndex = 7;
            dateOfRegistrationLabel.Text = "Date Of Registration:";
            // 
            // _Restaurant_DatabaseDataSet
            // 
            this._Restaurant_DatabaseDataSet.DataSetName = "_Restaurant_DatabaseDataSet";
            this._Restaurant_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(397, 280);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 36);
            this.button8.TabIndex = 28;
            this.button8.Text = "Cancel Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(270, 280);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 36);
            this.button7.TabIndex = 27;
            this.button7.Text = "Update All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 280);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 36);
            this.button6.TabIndex = 26;
            this.button6.Text = "Remove current";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 280);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 25;
            this.button5.Text = "Add new";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(397, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 32);
            this.button4.TabIndex = 24;
            this.button4.Text = "Move Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "Move Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "Move Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(19, 225);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 32);
            this.button9.TabIndex = 21;
            this.button9.Text = "Move First";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsLogsBindingSource, "GoodsId", true));
            this.comboBox1.DataSource = this.goodsBindingSource;
            this.comboBox1.DisplayMember = "GoodsName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Id";
            // 
            // goodsLogsBindingSource
            // 
            this.goodsLogsBindingSource.DataMember = "GoodsLogs";
            this.goodsLogsBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsLogsBindingSource, "ProviderId", true));
            this.comboBox2.DataSource = this.providersBindingSource;
            this.comboBox2.DisplayMember = "ProviderName";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(172, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 24);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.ValueMember = "Id";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsLogsBindingSource, "DeliveryId", true));
            this.comboBox3.DataSource = this.deliveryBindingSource;
            this.comboBox3.DisplayMember = "DeliveryName";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(172, 104);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(159, 24);
            this.comboBox3.TabIndex = 31;
            this.comboBox3.ValueMember = "Id";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantDatabaseDataSetBindingSource
            // 
            this.restaurantDatabaseDataSetBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            this.restaurantDatabaseDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeliveryTableAdapter = null;
            this.tableAdapterManager.GoodsLogsTableAdapter = this.goodsLogsTableAdapter;
            this.tableAdapterManager.GoodsTableAdapter = null;
            this.tableAdapterManager.ManufacturersTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restaurant._Restaurant_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // goodsLogsTableAdapter
            // 
            this.goodsLogsTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantViewTableAdapter
            // 
            this.restaurantViewTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantViewBindingSource
            // 
            this.restaurantViewBindingSource.DataMember = "RestaurantView";
            this.restaurantViewBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DateOfRegistration";
            this.dataGridViewTextBoxColumn1.HeaderText = "DateOfRegistration";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeliveryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DeliveryName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ManufacturerName";
            this.dataGridViewTextBoxColumn3.HeaderText = "ManufacturerName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn4.HeaderText = "GoodsName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GoodsCount";
            this.dataGridViewTextBoxColumn5.HeaderText = "GoodsCount";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProviderName";
            this.dataGridViewTextBoxColumn6.HeaderText = "ProviderName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(345, 61);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 33;
            this.button10.Text = "Edit";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(345, 104);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 34;
            this.button11.Text = "Edit";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // restaurantViewDataGridView
            // 
            this.restaurantViewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurantViewDataGridView.AutoGenerateColumns = false;
            this.restaurantViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.restaurantViewDataGridView.DataSource = this.restaurantViewBindingSource;
            this.restaurantViewDataGridView.Location = new System.Drawing.Point(523, 12);
            this.restaurantViewDataGridView.Name = "restaurantViewDataGridView";
            this.restaurantViewDataGridView.RowHeadersWidth = 51;
            this.restaurantViewDataGridView.RowTemplate.Height = 24;
            this.restaurantViewDataGridView.Size = new System.Drawing.Size(929, 306);
            this.restaurantViewDataGridView.TabIndex = 34;
            // 
            // dateOfRegistrationDateTimePicker
            // 
            this.dateOfRegistrationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.goodsLogsBindingSource, "DateOfRegistration", true));
            this.dateOfRegistrationDateTimePicker.Location = new System.Drawing.Point(172, 153);
            this.dateOfRegistrationDateTimePicker.Name = "dateOfRegistrationDateTimePicker";
            this.dateOfRegistrationDateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.dateOfRegistrationDateTimePicker.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DateOfRegistration";
            this.dataGridViewTextBoxColumn7.HeaderText = "DateOfRegistration";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DeliveryName";
            this.dataGridViewTextBoxColumn8.HeaderText = "DeliveryName";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ManufacturerName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ManufacturerName";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn10.HeaderText = "GoodsName";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GoodsCount";
            this.dataGridViewTextBoxColumn11.HeaderText = "GoodsCount";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProviderName";
            this.dataGridViewTextBoxColumn12.HeaderText = "ProviderName";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // GoodsLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 345);
            this.Controls.Add(this.dateOfRegistrationDateTimePicker);
            this.Controls.Add(this.restaurantViewDataGridView);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(dateOfRegistrationLabel);
            this.Controls.Add(deliveryIdLabel);
            this.Controls.Add(providerIdLabel);
            this.Controls.Add(goodsIdLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GoodsLogsForm";
            this.Text = "GoodsLogsForm";
            this.Load += new System.EventHandler(this.GoodsLogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Restaurant_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantViewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Restaurant_DatabaseDataSet _Restaurant_DatabaseDataSet;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource goodsLogsBindingSource;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private _Restaurant_DatabaseDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private _Restaurant_DatabaseDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.BindingSource restaurantDatabaseDataSetBindingSource;
        private _Restaurant_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _Restaurant_DatabaseDataSetTableAdapters.GoodsLogsTableAdapter goodsLogsTableAdapter;
        private _Restaurant_DatabaseDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private _Restaurant_DatabaseDataSetTableAdapters.RestaurantViewTableAdapter restaurantViewTableAdapter;
        private System.Windows.Forms.BindingSource restaurantViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView restaurantViewDataGridView;
        private System.Windows.Forms.DateTimePicker dateOfRegistrationDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}