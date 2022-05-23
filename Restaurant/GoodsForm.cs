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
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void goodsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Manufacturers' table. You can move, or remove it, as needed.
            this.manufacturersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Manufacturers);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Goods);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            goodsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            goodsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Validate();
            goodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(_Restaurant_DatabaseDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            goodsBindingSource.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var app = new ManufacturerForm();
            app.ShowDialog();
            var row = (DataRowView)manufacturersBindingSource.Current;
            var id = Convert.ToInt32(row.Row["Id"]);
            manufacturersTableAdapter.Fill(_Restaurant_DatabaseDataSet.Manufacturers);
            comboBox1.SelectedItem = comboBox1.Items.Cast<DataRowView>().Single(c => (int)c.Row["Id"] == id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var goodsDataRowView = goodsBindingSource.Current as DataRowView;
            var manufacturerDataRowView = manufacturersBindingSource1.Current as DataRowView;
            new GoodsReportForm(goodsDataRowView, manufacturerDataRowView).Show();
        }
    }
}
