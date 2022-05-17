using System.Windows.Forms;

namespace Restaurant
{
    public partial class GoodsLogsReportForm : Form
    {
        public GoodsLogsReportForm()
        {
            InitializeComponent();
        }

        private void GoodsReportForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.RestaurantView' table. You can move, or remove it, as needed.
            this.RestaurantViewTableAdapter.Fill(this._Restaurant_DatabaseDataSet.RestaurantView);
            // TODO: This line of code loads data into the '_Restaurant_DatabaseDataSet.Goods' table. You can move, or remove it, as needed.
            this.GoodsTableAdapter.Fill(this._Restaurant_DatabaseDataSet.Goods);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            RestaurantViewBindingSource.Filter = $"DateOfRegistration >= '{dateTimePicker1.Value}' and DateOfRegistration <= '{dateTimePicker2.Value}'";

            this.reportViewer1.RefreshReport();
        }
    }
}
