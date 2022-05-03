using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab5
{
    public partial class Form1 : Form
    {

        private const string QueryGetGoods = "SELECT * FROM Goods";
        private const string QueryGetManufacturers = "SELECT Id, manufacturerName FROM Manufacturers";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;

        private readonly SqlConnection _connection;
        private readonly SqlDataAdapter _adapter;

        public Form1()
        {
            _connection = new SqlConnection(ConnectionString);
            _adapter = new SqlDataAdapter(QueryGetGoods, _connection);
            InitializeComponent();
        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            var _dataset = new DataSet();
            _adapter.Fill(_dataset, "Goods");
            // Привязка исходных данных к элементу GridView1

            dataGridView1.DataSource = _dataset.Tables["Goods"];

            // Сортировка по фамилии и привязка к элементу GridView2

            var view2 = new DataView(_dataset.Tables["Goods"])
            {
                Sort = "Price"
            };

            dataGridView2.DataSource = view2;
            // Сортировка no имени и привязка к элементу GridView3

            var view3 = new DataView(_dataset.Tables["Goods"])
            {
                Sort = "GoodsName"
            };

            dataGridView3.DataSource = view3;

            // Привязка отфильтрованных данных к GridView4

            var view4 = new DataView(_dataset.Tables["Goods"]);
            if (cb_Filter1.SelectedIndex == 0 && cb_Filter2.SelectedIndex == 1)
            {
                view4.RowFilter = "ManufacturerId=7";
                dataGridViewFilter.DataSource = view4;
                label1.Text = "Filter = manufacturer ID = 7";
            }
            if (cb_Filter1.SelectedIndex == 1 && cb_Filter2.SelectedIndex == 0)
            {
                view4.RowFilter = "Price=5000";
                dataGridViewFilter.DataSource = view4;
                label1.Text = "Filter = Price = 5000";
            }
            if (cb_Filter1.SelectedIndex == 0 && cb_Filter2.SelectedIndex == 0)
            {
                view4.RowFilter = "ManufacturerId=7 and Price=5000";
                dataGridViewFilter.DataSource = view4;
                label1.Text = "Filter = manufacturer ID = 7 and price = 5000";
            }
            if (cb_Filter1.SelectedIndex == 1 && cb_Filter2.SelectedIndex == 1)
            {
                dataGridViewFilter.DataSource = view4;
                label1.Text = "Filter = NONE";
            }
            //часть 4
            var adapter2 = new SqlDataAdapter(QueryGetManufacturers, _connection);
            var dataset2 = new DataSet();
            adapter2.Fill(dataset2, "Manufacturers");
            adapter2.SelectCommand.CommandText = QueryGetGoods;
            adapter2.Fill(dataset2, "Goods");

            var relation = new DataRelation("ManGoods",
                dataset2.Tables["Manufacturers"].Columns["Id"],
                dataset2.Tables["Goods"].Columns["ManufacturerId"]);
            dataset2.Relations.Add(relation);

            var count = new DataColumn("Product count", typeof(int), "COUNT(Child(ManGoods).ManufacturerId)");
            var max = new DataColumn("Product with max cost: ", typeof(decimal), "MAX(Child(ManGoods).Price)");
            var min = new DataColumn("Product with min cost", typeof(decimal), "MIN(Child(ManGoods).Price)");

            // Добавить столбцы

            dataset2.Tables["Manufacturers"].Columns.Add(count);
            dataset2.Tables["Manufacturers"].Columns.Add(max);
            dataset2.Tables["Manufacturers"].Columns.Add(min);
            dataGridView4.DataSource = dataset2.Tables["Manufacturers"];
        }
    }
}
