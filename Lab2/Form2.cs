using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        private const string QueryExecuteGoodsView = "SELECT * FROM GoodsView";
        private const string QueryGetGoodsCount = "EXECUTE GetGoodsCount";
        private const string QueryNameInsertGoods = "GoodsInsertData";

        internal readonly string ConnectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;
        internal readonly SqlConnection Connection;

        public Form2()
        {
            Connection = new SqlConnection(ConnectionString);
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var cmd = new SqlCommand(QueryNameInsertGoods, Connection)
            {
                CommandType = CommandType.StoredProcedure,
            };
            cmd.Parameters.AddWithValue("@manufacturerId", int.Parse(manufacturerId.Text));
            cmd.Parameters.AddWithValue("@goodsName", goodsName.Text);
            cmd.Parameters.AddWithValue("@price", decimal.Parse(price.Text));
            cmd.Parameters.AddWithValue("@count", int.Parse(count.Text));

            cmd.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 4));
            cmd.Parameters["@Id"].Direction = ParameterDirection.Output;

            Connection.Open();
            try
            {
                int numAff = cmd.ExecuteNonQuery();

                label3.Text = "Добавлена запись" + numAff;

                // Получить вновь сгенерированный идентификатор
                var c = cmd.Parameters["@Id"].Value;

                label8.Text = "Новому товару присвоен ID: " + cmd.Parameters["@Id"].Value;
            }
            finally
            {
                Connection.Close();
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand()
            {
                Connection = Connection,
                CommandType = CommandType.Text,
                CommandText = QueryExecuteGoodsView
            };

            Connection.Open();
            try
            {
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var result = reader.GetValue(1)
                        + "\t"
                        + reader.GetValue(2)
                        + "\t\t"
                        + reader.GetValue(3)
                        + "\t"
                        + reader.GetValue(4);

                    listBox1.Items.Insert(0, result);
                }
                reader.Close();
            }
            finally
            {
                Connection.Close();
            }
        }

        private void BtnGetCount_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand(QueryGetGoodsCount, Connection);

            Connection.Open();
            try
            {
                var count = (int)command.ExecuteScalar();

                label1.Text = $"Количество всех товаров: {count}"; // 9
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
