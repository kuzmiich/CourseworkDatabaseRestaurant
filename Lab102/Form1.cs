using System;
using System.Configuration;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["LocalDatabase"].ConnectionString;
        private readonly ProviderRepository _repository;
        private readonly DataClassesDataContext _context;
        public Form1()
        {
            _context = new DataClassesDataContext(_connectionString);
            _repository = new ProviderRepository(_context);
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _repository.GetAll();
        }
        private void ButtonFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
