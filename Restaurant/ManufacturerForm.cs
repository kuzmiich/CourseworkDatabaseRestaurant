using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class ManufacturerForm : Form
    {
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        private void manufacturersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void ManufacturerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Manufacturers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Validate();
            manufacturersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(_Restaurant_DatabaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            manufacturersBindingSource.CancelEdit();
        }
    }
}
