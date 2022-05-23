
namespace Restaurant
{
    partial class GoodsForm
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
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label goodsNameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label countLabel;
            System.Windows.Forms.Label isDeletedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsForm));
            this.goodsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Restaurant_DatabaseDataSet = new Restaurant._Restaurant_DatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.goodsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.goodsNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.isDeletedCheckBox = new System.Windows.Forms.CheckBox();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.manufacturersTableAdapter = new Restaurant._Restaurant_DatabaseDataSetTableAdapters.ManufacturersTableAdapter();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            goodsNameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            isDeletedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).BeginInit();
            this.goodsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Restaurant_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Location = new System.Drawing.Point(24, 53);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(137, 17);
            manufacturerIdLabel.TabIndex = 1;
            manufacturerIdLabel.Text = "Manufacturer Name:";
            // 
            // goodsNameLabel
            // 
            goodsNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            goodsNameLabel.AutoSize = true;
            goodsNameLabel.Location = new System.Drawing.Point(24, 87);
            goodsNameLabel.Name = "goodsNameLabel";
            goodsNameLabel.Size = new System.Drawing.Size(95, 17);
            goodsNameLabel.TabIndex = 3;
            goodsNameLabel.Text = "Goods Name:";
            // 
            // priceLabel
            // 
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(24, 123);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(44, 17);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Price:";
            // 
            // countLabel
            // 
            countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(24, 159);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(49, 17);
            countLabel.TabIndex = 7;
            countLabel.Text = "Count:";
            // 
            // isDeletedLabel
            // 
            isDeletedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            isDeletedLabel.AutoSize = true;
            isDeletedLabel.Location = new System.Drawing.Point(24, 193);
            isDeletedLabel.Name = "isDeletedLabel";
            isDeletedLabel.Size = new System.Drawing.Size(75, 17);
            isDeletedLabel.TabIndex = 9;
            isDeletedLabel.Text = "Is Deleted:";
            // 
            // goodsBindingNavigator
            // 
            this.goodsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.goodsBindingNavigator.BindingSource = this.goodsBindingSource;
            this.goodsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.goodsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.goodsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.goodsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.goodsBindingNavigatorSaveItem});
            this.goodsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.goodsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.goodsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.goodsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.goodsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.goodsBindingNavigator.Name = "goodsBindingNavigator";
            this.goodsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.goodsBindingNavigator.Size = new System.Drawing.Size(1108, 27);
            this.goodsBindingNavigator.TabIndex = 0;
            this.goodsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // _Restaurant_DatabaseDataSet
            // 
            this._Restaurant_DatabaseDataSet.DataSetName = "_Restaurant_DatabaseDataSet";
            this._Restaurant_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(49, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // goodsBindingNavigatorSaveItem
            // 
            this.goodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goodsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("goodsBindingNavigatorSaveItem.Image")));
            this.goodsBindingNavigatorSaveItem.Name = "goodsBindingNavigatorSaveItem";
            this.goodsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.goodsBindingNavigatorSaveItem.Text = "Save Data";
            this.goodsBindingNavigatorSaveItem.Click += new System.EventHandler(this.goodsBindingNavigatorSaveItem_Click_1);
            // 
            // goodsNameTextBox
            // 
            this.goodsNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.goodsNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "GoodsName", true));
            this.goodsNameTextBox.Location = new System.Drawing.Point(167, 87);
            this.goodsNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goodsNameTextBox.Name = "goodsNameTextBox";
            this.goodsNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.goodsNameTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(167, 123);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 6;
            // 
            // countTextBox
            // 
            this.countTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "Count", true));
            this.countTextBox.Location = new System.Drawing.Point(167, 156);
            this.countTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(121, 22);
            this.countTextBox.TabIndex = 8;
            // 
            // isDeletedCheckBox
            // 
            this.isDeletedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isDeletedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.goodsBindingSource, "IsDeleted", true));
            this.isDeletedCheckBox.Location = new System.Drawing.Point(167, 193);
            this.isDeletedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isDeletedCheckBox.Name = "isDeletedCheckBox";
            this.isDeletedCheckBox.Size = new System.Drawing.Size(19, 21);
            this.isDeletedCheckBox.TabIndex = 10;
            this.isDeletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goodsDataGridView.AutoGenerateColumns = false;
            this.goodsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.goodsDataGridView.DataSource = this.goodsBindingSource;
            this.goodsDataGridView.Location = new System.Drawing.Point(506, 30);
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.RowHeadersWidth = 51;
            this.goodsDataGridView.RowTemplate.Height = 24;
            this.goodsDataGridView.Size = new System.Drawing.Size(602, 337);
            this.goodsDataGridView.TabIndex = 12;
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "Manufacturers";
            this.manufacturersBindingSource.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // manufacturersBindingSource1
            // 
            this.manufacturersBindingSource1.DataMember = "Manufacturers";
            this.manufacturersBindingSource1.DataSource = this._Restaurant_DatabaseDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeliveryTableAdapter = null;
            this.tableAdapterManager.GoodsLogsTableAdapter = null;
            this.tableAdapterManager.GoodsTableAdapter = this.goodsTableAdapter;
            this.tableAdapterManager.ManufacturersTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Restaurant._Restaurant_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(386, 331);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 36);
            this.button8.TabIndex = 20;
            this.button8.Text = "Cancel Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(267, 331);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 36);
            this.button7.TabIndex = 19;
            this.button7.Text = "Update All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(133, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 36);
            this.button6.TabIndex = 18;
            this.button6.Text = "Remove current";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add new";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 32);
            this.button4.TabIndex = 16;
            this.button4.Text = "Move Last";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(267, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Move Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Move Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 276);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 32);
            this.button9.TabIndex = 13;
            this.button9.Text = "Move First";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.goodsBindingSource, "ManufacturerId", true));
            this.comboBox1.DataSource = this.manufacturersBindingSource;
            this.comboBox1.DisplayMember = "ManufacturerName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "Id";
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(334, 159);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 55);
            this.button10.TabIndex = 23;
            this.button10.Text = "Create Purchase ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ManufacturerId";
            this.dataGridViewTextBoxColumn2.DataSource = this.manufacturersBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "ManufacturerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ManufacturerId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 132;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GoodsName";
            this.dataGridViewTextBoxColumn3.HeaderText = "GoodsName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 116;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 69;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Count";
            this.dataGridViewTextBoxColumn5.HeaderText = "Count";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 74;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsDeleted";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 73;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 380);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.goodsDataGridView);
            this.Controls.Add(isDeletedLabel);
            this.Controls.Add(this.isDeletedCheckBox);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(goodsNameLabel);
            this.Controls.Add(this.goodsNameTextBox);
            this.Controls.Add(manufacturerIdLabel);
            this.Controls.Add(this.goodsBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingNavigator)).EndInit();
            this.goodsBindingNavigator.ResumeLayout(false);
            this.goodsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Restaurant_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _Restaurant_DatabaseDataSet _Restaurant_DatabaseDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private _Restaurant_DatabaseDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private _Restaurant_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator goodsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton goodsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox goodsNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.CheckBox isDeletedCheckBox;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private _Restaurant_DatabaseDataSetTableAdapters.ManufacturersTableAdapter manufacturersTableAdapter;
        private System.Windows.Forms.BindingSource manufacturersBindingSource1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}