using Project_1.EditDialogs;
using Project_1.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Employees_Form : Form
    {
        private EmployeeDAO employeeDAO = new EmployeeDAO();
        private List<string> employeesDataList = new List<string>();

        public Employees_Form()
        {
            InitializeComponent();
            this.EmployeesTable.MultiSelect = false;
        }

        private void Employees_Form_Load(object sender, EventArgs e)
        {
            EmployeesTable.DataSource = employeeDAO.GetAllEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployee = new EditEmployee();
            editEmployee.ShowDialog();
            EmployeesTable.DataSource = employeeDAO.GetAllEmployees();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedCellCount = EmployeesTable.GetCellCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedCellCount; i++)
            {
                employeesDataList.Add(EmployeesTable.CurrentRow.Cells[i].Value.ToString());
            }

            EditEmployee editEmployee = new EditEmployee();
            editEmployee.EmployeeId = Convert.ToInt32(employeesDataList[0]);
            editEmployee.employeesDataList = employeesDataList;
            editEmployee.ShowDialog();
            EmployeesTable.DataSource = employeeDAO.GetAllEmployees();
            employeesDataList.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(EmployeesTable.CurrentRow.Cells[0].Value.ToString());
            employeeDAO.Delete(id);
            EmployeesTable.DataSource = employeeDAO.GetAllEmployees();
        }
    }
}
