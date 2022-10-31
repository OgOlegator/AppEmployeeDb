using AppEmployeeDb.DbContexts;
using AppEmployeeDb.Models;
using AppEmployeeDb.Repository;
using System.Windows.Forms;

namespace AppEmployeeDb

{
    public partial class FormEmployees : Form
    {
        private readonly ApplicationDbContext _db;
        private readonly IEmloyeeRepository _repository;

        public FormEmployees()
        {
            _db = new ApplicationDbContext();
            _repository = new EmloyeeRepository(_db);

            InitializeComponent();

            UpdateDataGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AdditionalForm(_repository).ShowDialog();

            UpdateDataGrid();
        }

        private async void UpdateDataGrid()
        {
            var listEmployees = await _repository.GetEmployee();

            employeesDataGrid.DataSource = listEmployees;
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var id = (int) employeesDataGrid.SelectedRows[0].Cells[0].Value;

            var result = await _repository.DeleteEmployee(id);

            if (!result)
            {
                MessageBox.Show("Не удалось удалить запись");
                return;
            }

            UpdateDataGrid();
        }
    }
}