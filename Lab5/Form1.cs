using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private const string TableName = "Goods";
        private const string QueryGetGoods = "SELECT * FROM Goods";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;

        private readonly SqlConnection _connection;
        private readonly SqlDataAdapter _adapter;
        private readonly DataSet _dataSet;

        public Form1()
        {
            _dataSet = new DataSet();
            _connection = new SqlConnection(ConnectionString);
            _adapter = new SqlDataAdapter(QueryGetGoods, _connection);
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            _adapter.Fill(_dataSet, TableName);

            // Привязка исходных данных к элементу GridView1
            dataGridView1.DataSource = _dataSet.Tables[TableName];

            // Сортировка по фамилии и привязка к элементу GridView2
            var view2 = new DataView(_dataSet.Tables[TableName])
            {
                Sort = "Price"
            };

            dataGridView1.DataSource = view2;
            // Сортировка no имени и привязка к элементу GridView3

            var view3 = new DataView(_dataSet.Tables[TableName])
            {
                Sort = "Name"
            };

            dataGridView1.DataSource = view3;

            // Привязка отфильтрованных данных к GridView4

            var view4 = new DataView(_dataSet.Tables[TableName]);

            switch (cb_Filter1.SelectedIndex)
            {
                case 0 when cb_Filter2.SelectedIndex == 1:
                    view4.RowFilter = "ManufacturerId=7";
                    dataGridView1.DataSource = view4;
                    label1.Text = "Filter = manufacturer id = 7";
                    break;
                case 1 when cb_Filter2.SelectedIndex == 0:
                    view4.RowFilter = "price=5000";
                    dataGridView1.DataSource = view4;
                    label1.Text = "Filter = price = 5000";
                    break;
                case 0 when cb_Filter2.SelectedIndex == 0:
                    view4.RowFilter = "ManufacturerId=7 and price=5000";
                    dataGridView1.DataSource = view4;
                    label1.Text = "Filter = manufacturer ID = 7 and price = 5000";
                    break;
                default:// 1 & 1
                    dataGridView1.DataSource = view4;
                    label1.Text = "Filter = NONE";
                    break;
            }

            //часть 4
            string sqlMan = "SELECT ManufacturerId, manufacturerName FROM Manufacturer";
            string sqlGoods = "SELECT name, ManufacturerId, price FROM Goods";

            var adapter2 = new SqlDataAdapter(sqlMan, _connection);
            var dataset2 = new DataSet();
            adapter2.Fill(dataset2, "Manufacturer");
            adapter2.SelectCommand.CommandText = sqlGoods;
            adapter2.Fill(dataset2, TableName);

            var relation = new DataRelation("ManGoods",
                dataset2.Tables["Manufacturer"].Columns["ManufacturerId"],
                dataset2.Tables[TableName].Columns["ManufacturerId"]);
            dataset2.Relations.Add(relation);

            var count = new DataColumn("Кол-во продуктов", typeof(int), "COUNT(Child(ManGoods).ManufacturerId)");
            var max = new DataColumn("Самый дорогой продукт: стоимость", typeof(decimal), "MAX(Child(ManGoods).price)");
            var min = new DataColumn("Самый дешевый продукт: стоимость", typeof(decimal), "MIN(Child(ManGoods).price)");

            // Добавить столбцы
            dataset2.Tables["Manufacturer"].Columns.Add(count);
            dataset2.Tables["Manufacturer"].Columns.Add(max);
            dataset2.Tables["Manufacturer"].Columns.Add(min);
            dataGridView1.DataSource = dataset2.Tables["Manufacturer"];

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            _dataSet.Clear();
        }
    }
}
