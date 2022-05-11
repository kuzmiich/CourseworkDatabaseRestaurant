using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Threading;
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
            UpdateDataGridView(_repository.GetAll());
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void SelectedIndexChanged_Click(object sender, ItemCheckEventArgs e)
        {
            string filterCriteria = checkedListBox1.SelectedItem.ToString();

            IEnumerable<Provider> providers;
            switch (filterCriteria)
            {
                case "Id":
                    providers = _repository.GetAll().OrderBy(x => x.Id);
                    break;
                case "ProviderName":
                    providers = _repository.GetAll().OrderBy(x => x.ProviderName);
                    break;
                case "Description":
                    providers = _repository.GetAll().OrderBy(x => x.Description);
                    break;
                default:
                    providers = _repository.GetAll().OrderBy(x => x.Id);
                    break;
            };
            UpdateDataGridView(providers);
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            var filterCriteria = textBox1.Text;
            var filteredProviders = _repository.GetAll().Where(provider => filterCriteria != string.Empty ? 
            provider.ProviderName == filterCriteria : 
            true);

            UpdateDataGridView(filteredProviders);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            _repository.Create(GetProviderFromForm());

            _repository.SubmitChanges();

            UpdateDataGridView(_repository.GetAll());
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            var newProvider = new Provider()
            {
                Id = int.Parse(textBox4.Text),
                ProviderName = textBox2.Text,
                Description = textBox3.Text
            };
            _repository.Update(newProvider);
            

            _repository.SubmitChanges();

            UpdateDataGridView(_repository.GetAll());
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var deletedProvider = _repository.GetAll()
                                            .OrderByDescending(x => x.Id)
                                            .First();

            _repository.Delete(deletedProvider);
            _repository.SubmitChanges();

            UpdateDataGridView(_repository.GetAll());
        }

        private Provider GetProviderFromForm() => new Provider()
        {
            ProviderName = textBox2.Text,
            Description = textBox3.Text
        };

        private void UpdateDataGridView(IEnumerable<Provider> table)
        {
            dataGridView1.DataSource = table;
        }
    }
}
