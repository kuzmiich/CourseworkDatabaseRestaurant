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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            goodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this._Restaurant_DatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Goods' table. You can move, or remove it, as needed.
            goodsTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Goods);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var createManufacturer = new Form5();
            createManufacturer.Show();
        }
    }
}
