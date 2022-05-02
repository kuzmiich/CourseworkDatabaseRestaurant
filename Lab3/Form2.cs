using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;


namespace Lab3
{
    public partial class Form2 : Form
    {
        private const string QueryGetGoods = "SELECT * FROM Goods";

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;

        private readonly SqlConnection _connection;
        private readonly SqlDataAdapter _adapter;
        private DataSet _dataset = new();

        public Form2()
        {
            _connection = new SqlConnection(ConnectionString);
            _adapter = new SqlDataAdapter(QueryGetGoods, _connection);
            _adapter.Fill(_dataset, "Goods");
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var builder = new SqlCommandBuilder(_adapter);

            DataTable GoodsTable = _dataset.Tables["Goods"];
            DataRow row = GoodsTable.NewRow();

            row["ManufacturerId"] = int.Parse(numericUpDown1.Text);
            row["GoodsName"] = tbName.Text;
            row["Price"] = decimal.Parse(numericUpDown2.Text);
            row["Count"] = int.Parse(numericUpDown3.Text);

            GoodsTable.Rows.Add(row);
            builder.GetInsertCommand();
            _adapter.Update(_dataset, "Goods");
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            list1.Items.Clear();
        }

        private void btnManualFilling_Click(object sender, EventArgs e)
        {
            var database = new DataSet("BookStore");
            var booksTable = new DataTable("Books");

            // добавление таблицы в dataset
            database.Tables.Add(booksTable);

            // создание столбцов для таблицы Books
            var idColumn = new DataColumn("Id", typeof(int))
            {
                Unique = true, // столбец будет иметь уникальное значение
                AllowDBNull = false, // не может принимать null
                AutoIncrement = true, // будет автоинкрементироваться
                AutoIncrementSeed = 1, // начальное значение
                AutoIncrementStep = 1 // приращении при добавлении новой строки
            };

            var nameColumn = new DataColumn("Name", Type.GetType("System.String"));
            var priceColumn = new DataColumn("Price", Type.GetType("System.Decimal"));
            var discountColumn = new DataColumn("Discount", Type.GetType("System.Decimal"))
            {
                Expression = "Price * 0.2"
            };

            booksTable.Columns.AddRange(new[] { idColumn, nameColumn, priceColumn, discountColumn });

            // определение первичного ключа таблицы books
            booksTable.PrimaryKey = new DataColumn[] { booksTable.Columns["Id"] };

            booksTable.NewRow();
            booksTable.Rows.Add(new object[] { null, "Война и мир", 200 });
            booksTable.Rows.Add(new object[] { null, "Отцы и дети", 170 });
            booksTable.Rows.Add(new object[] { null, "Преступление и наказание", 270 });
            booksTable.Rows.Add(new object[] { null, "Идиот", 270 });
            booksTable.Rows.Add(new object[] { null, "Арзипелаг ГУЛАГ", 3000 });

            foreach (DataRow r in booksTable.Rows)
            {
                var result = new StringBuilder();
                foreach (var cell in r.ItemArray)
                    result.Append(cell + " ");

                list1.Items.Add(result);

            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            // Вывод из DataSet строк таблицы Goods в элемент list1
            foreach (DataRow row in _dataset.Tables["Goods"].Rows)
            {
                string result = row["Id"].ToString() + " "
                    + row["ManufacturerId"].ToString() + " "
                    + row["GoodsName"] + " "
                    + row["Price"].ToString() + ""
                    + row["Count"].ToString();

                list1.Items.Add(result);
            }
            _dataset.Clear();
        }
    }
}
