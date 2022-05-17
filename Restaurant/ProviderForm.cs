using System;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class ProviderForm : Form
    {
        public ProviderForm()
        {
            InitializeComponent();
        }

        private void providersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Providers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            providersBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            providersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            providersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            providersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            providersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            providersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Validate();
            providersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(_Restaurant_DatabaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            providersBindingSource.CancelEdit();
        }
    }
}
