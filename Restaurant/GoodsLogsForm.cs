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
    public partial class GoodsLogsForm : Form
    {
        public GoodsLogsForm()
        {
            InitializeComponent();
        }

        private void goodsLogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsLogsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);
            restaurantViewTableAdapter.Fill(this._Restaurant_DatabaseDataSet.RestaurantView);

        }

        private void GoodsLogsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Delivery);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Providers' table. You can move, or remove it, as needed.
            this.providersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Providers);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Goods);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.GoodsLogs' table. You can move, or remove it, as needed.
            this.goodsLogsTableAdapter.Fill(this._Restaurant_DatabaseDataSet.GoodsLogs);

            restaurantViewTableAdapter.Fill(this._Restaurant_DatabaseDataSet.RestaurantView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            goodsLogsBindingNavigatorSaveItem_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            goodsLogsBindingSource.CancelEdit();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.restaurantViewTableAdapter.Fill(this._Restaurant_DatabaseDataSet.RestaurantView);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var app = new GoodsForm();
            app.ShowDialog();
            var row = (DataRowView)goodsBindingSource.Current;
            var id = Convert.ToInt32(row.Row["Id"]);
            goodsTableAdapter.Fill(_Restaurant_DatabaseDataSet.Goods);
            comboBox1.SelectedItem = comboBox1.Items.Cast<DataRowView>().Single(c => (int)c.Row["Id"] == id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var app = new ProviderForm();
            app.ShowDialog();
            var row = (DataRowView)providersBindingSource.Current;
            var id = Convert.ToInt32(row.Row["Id"]);
            providersTableAdapter.Fill(_Restaurant_DatabaseDataSet.Providers);
            comboBox2.SelectedItem = comboBox2.Items.Cast<DataRowView>().Single(c => (int)c.Row["Id"] == id);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var app = new DeliveryForm();
            app.ShowDialog();
            var row = (DataRowView)deliveryBindingSource.Current;
            var id = Convert.ToInt32(row.Row["Id"]);
            deliveryTableAdapter.Fill(_Restaurant_DatabaseDataSet.Delivery);
            comboBox3.SelectedItem = comboBox3.Items.Cast<DataRowView>().Single(c => (int)c.Row["Id"] == id);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            new GoodsLogsReportForm().Show();
        }
    }
}
