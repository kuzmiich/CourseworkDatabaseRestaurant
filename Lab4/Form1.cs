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

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;

        private readonly SqlConnection _connection;
        private readonly SqlDataAdapter _adapter;
        private DataSet _dataset = new();

        public Form1()
        {
            _connection = new SqlConnection(ConnectionString);
            _adapter = new SqlDataAdapter(QueryGetGoods, _connection);
            _adapter.Fill(_dataset, "Goods");
            InitializeComponent();
        }


    }
}
