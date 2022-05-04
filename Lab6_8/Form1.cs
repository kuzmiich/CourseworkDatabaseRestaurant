using System;
using System.Windows.Forms;

namespace Lab6_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            manufacturersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Manufacturers);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Manufacturers' table. You can move, or remove it, as needed.
            manufacturersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Manufacturers);
        }

        private void manufacturersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }
    }
}
