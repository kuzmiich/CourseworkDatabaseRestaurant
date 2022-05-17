using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Delivery);

        }

        private void deliveryBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void DeliveryForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Delivery);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Validate();
            deliveryBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(_Restaurant_DatabaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.CancelEdit();
        }
    }
}
