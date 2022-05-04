using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_9
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void manufacturersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            manufacturersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Manufacturers' table. You can move, or remove it, as needed.
            manufacturersTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Manufacturers);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Goods' table. You can move, or remove it, as needed.
            goodsTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Goods);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var app = new Form1();
            app.FormClosed += App_FormClosed;
            app.Show();
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            var row = (DataRowView)manufacturersBindingSource.Current;

            var id = Convert.ToInt32(row.Row["Id"]);
            manufacturersTableAdapter.Fill(_Restaurant_DatabaseDataSet.Manufacturers);

            comboBox1.SelectedItem = comboBox1.Items.Cast<DataRowView>().Single(c => (int)c.Row["Id"] == id);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MoveLast();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.CancelEdit();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Validate();
            goodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(_Restaurant_DatabaseDataSet);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.RemoveCurrent();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.AddNew();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MoveNext();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            goodsBindingSource.MovePrevious();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveFirst();
        }
    }
}
