using Microsoft.Reporting.WinForms;
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
    public partial class GoodsReportForm : Form
    {
        public GoodsReportForm()
        {
            InitializeComponent();
        }
        public GoodsReportForm(DataRowView goods, DataRowView manufacturer) : this()
        {
            Manufacturers = manufacturer;
            Goods = goods;
        }

        public DataRowView Manufacturers { get; private set; }
        public DataRowView Goods { get; private set; }

        private void GoodsReportForm_Load(object sender, EventArgs e)
        {

            var manufacturerName = Manufacturers.Row["ManufacturerName"];
            var goodsName = Goods.Row["GoodsName"];
            var price = Goods.Row["Price"];
            var count = Goods.Row["Count"];

            var goodsNameTypeParam = new ReportParameter("Goods_Name", goodsName.ToString());
            var priceTypeParam = new ReportParameter("Price", price.ToString());
            var countTypeParam = new ReportParameter("Count", count.ToString());
            var manufacturerNameTypeParam = new ReportParameter("Manufacturer_Name", manufacturerName.ToString());

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {
                goodsNameTypeParam,
                priceTypeParam,
                countTypeParam,
                manufacturerNameTypeParam,
            });

            this.reportViewer1.RefreshReport();
        }
    }
}
