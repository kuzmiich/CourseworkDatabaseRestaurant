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

namespace Lab4
{
    public partial class Form1 : Form
    {
        private const string QueryGetGoods = "SELECT * FROM Goods";
        private const string QueryGetManufacturers = "SELECT * FROM Manufacturers";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;

        private readonly SqlConnection _connection;
        private SqlDataAdapter _adapter;

        public Form1()
        {
            _connection = new SqlConnection(ConnectionString);
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                var ds = new DataSet();
                SetUpManufacturers(ds);
                SetUpGoods(ds);
                SetUpRelations(ds);

                _adapter = new SqlDataAdapter(QueryGetManufacturers, _connection);
                var dataset = new DataSet();
                _adapter.Fill(dataset, "Goods");
                _adapter.SelectCommand.CommandText = QueryGetGoods;
                _adapter.Fill(dataset, "Manufacturers");

                dataGridView1.DataSource = dataset.Tables["Goods"];
                dataGridView2.DataSource = dataset.Tables["Manufacturers"];
            }
            finally
            {
                _connection.Close();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox5.Text = $"{e.RowIndex + 1}";
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            checkBox1.Checked = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox6.Text = $"{e.RowIndex + 1}";
            textBox7.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            checkBox2.Checked = bool.Parse(dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (dataGridView2.DataSource is not DataTable table) return;

            foreach (DataRow row in table.Rows)
            {
                listBox1.Items.Add($"{row[1]}");

                foreach (DataRow row2 in row.GetChildRows("GoodsManufacturers"))
                {
                    listBox1.Items.Add($"\t{row2[1]} {row2[2]} {row2[3]}");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            checkBox1.Checked = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            checkBox2.Checked = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var table = dataGridView1.DataSource as DataTable;

            if (table is null) return;

            _connection.Open();
            try
            {
                var adapter = new SqlDataAdapter(QueryGetGoods, _connection);
                var builder = new SqlCommandBuilder(adapter);

                builder.GetInsertCommand();
                builder.GetDeleteCommand();

                adapter.Update(table);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var table = dataGridView2.DataSource as DataTable;

            if (table is null) return;

            _connection.Open();
            try
            {
                var adapter = new SqlDataAdapter(QueryGetManufacturers, _connection);

                var builder = new SqlCommandBuilder(adapter);

                builder.GetInsertCommand();
                builder.GetDeleteCommand();

                adapter.Update(table);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = dataGridView1.DataSource as DataTable;

            if (table is null) return;

            table.Rows.Add(new object[] {null,
                int.Parse(textBox4.Text),
                textBox1.Text,
                int.Parse(textBox2.Text),
                decimal.Parse(textBox3.Text),
                checkBox1.Checked});
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var table = dataGridView1.DataSource as DataTable;

            if (table is null) return;

            var index = int.Parse(textBox5.Text) - 1;
            var row = table.Rows[index];

            row["GoodsName"] = textBox1.Text;
            row["Count"] = int.Parse(textBox2.Text);
            row["Price"] = decimal.Parse(textBox3.Text);
            row["ManufacturerId"] = int.Parse(textBox4.Text);
            row["IsDeleted"] = checkBox1.Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var table = dataGridView1.DataSource as DataTable;

            if (table is null) return;

            var index = int.Parse(textBox5.Text) - 1;
            var row = table.Rows[index];
            row.Delete();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var table = dataGridView1.DataSource as DataTable;

            if (table is null) return;

            table.AcceptChanges();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var table = dataGridView2.DataSource as DataTable;

            if (table is null) return;

            table.AcceptChanges();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var table = dataGridView2.DataSource as DataTable;

            if (table is null) return;

            table.Rows.Add(new object[] { null, textBox7.Text, checkBox2.Checked });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var table = dataGridView2.DataSource as DataTable;

            if (table is null) return;

            var index = int.Parse(textBox6.Text) - 1;
            var row = table.Rows[index];

            row["ManufacturerName"] = textBox7.Text;
            row["IsDeleted"] = checkBox2.Checked;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var table = dataGridView2.DataSource as DataTable;

            if (table is null) return;

            var index = int.Parse(textBox6.Text) - 1;
            var row = table.Rows[index];
            row.Delete();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            UpdateTable(dataGridView2, "Manufacturers");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            UpdateTable(dataGridView1, "Goods");
        }

        private void UpdateTable(DataGridView view, string name)
        {
            var table = view.DataSource as DataTable;

            if (table is null) return;

            var regSelect = $"SELECT * FROM {name}";
            _connection.Open();
            try
            {
                var adapter = new SqlDataAdapter(regSelect, _connection);

                var ds = table.DataSet;

                view.DataSource = null;

                ds.Tables[name].Clear();

                adapter.Fill(ds.Tables[name]);

                view.DataSource = ds.Tables[name];
            }
            finally
            {
                _connection.Close();
            }
        }

        private void RejectChanges(DataGridView view, DataRowState state)
        {
            var table = view.DataSource as DataTable;

            if (table is null) return;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i].RowState == state)
                {
                    table.Rows[i].RejectChanges();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RejectChanges(dataGridView1, DataRowState.Added);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RejectChanges(dataGridView1, DataRowState.Modified);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RejectChanges(dataGridView1, DataRowState.Deleted);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RejectChanges(dataGridView2, DataRowState.Added);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RejectChanges(dataGridView2, DataRowState.Modified);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RejectChanges(dataGridView2, DataRowState.Deleted);
        }

        private static void SetUpGoods(DataSet ds)
        {
            var regTable = ds.Tables.Add("Goods");
            var idRegColumn = regTable.Columns.Add("Id");
            idRegColumn.AutoIncrement = true;
            idRegColumn.AutoIncrementSeed = 1;
            idRegColumn.AutoIncrementStep = 1;
            regTable.Columns.Add("ManufacturerId", typeof(int));
            regTable.Columns.Add("GoodsName", typeof(string)).Unique = true;
            regTable.Columns.Add("Price", typeof(decimal));
            regTable.Columns.Add("Count", typeof(int));
            regTable.Columns.Add("IsDeleted", typeof(byte)).DefaultValue = 0;
            regTable.PrimaryKey = new DataColumn[] { idRegColumn };
        }

        private static void SetUpManufacturers(DataSet ds)
        {
            var patTable = ds.Tables.Add("Manufacturers");
            var idPatColumn = patTable.Columns.Add("Id");
            idPatColumn.AutoIncrement = true;
            idPatColumn.AutoIncrementSeed = 1;
            idPatColumn.AutoIncrementStep = 1;
            patTable.Columns.Add("ManufacturerName", typeof(string)).Unique = true;
            patTable.Columns.Add("IsDeleted", typeof(byte)).DefaultValue = 0;
            patTable.PrimaryKey = new DataColumn[] { idPatColumn };
        }

        private static void SetUpRelations(DataSet ds)
        {
            var forKey = new DataRelation("Goods_Manufacturers",
                                            ds.Tables["Goods"].Columns["ManufacturerId"],
                                            ds.Tables["Manufacturers"].Columns["Id"]);
            ds.Relations.Add(forKey);
        }
    }
}
