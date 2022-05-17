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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManufacturerForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ProviderForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new DeliveryForm().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new GoodsForm().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new GoodsLogsForm().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new GoodsLogsReportForm().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
