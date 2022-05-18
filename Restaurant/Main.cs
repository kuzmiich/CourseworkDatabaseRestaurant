using System;
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

        private void button6_Click(object sender, EventArgs e)
        {
            new GoodsLogsReportForm().Show();
        }
    }
}
