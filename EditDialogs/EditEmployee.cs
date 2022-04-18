using Project_1.Models;
using Project_1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1.EditDialogs
{
    public partial class EditEmployee : Form
    {
        public int EmployeeId { get; set; }
        public List<string> employeesDataList = new List<string>();
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public EditEmployee()
        {
            InitializeComponent();
            string[] genders = { "Male", "Female" };
            comboBoxMale.Items.AddRange(genders);

            List<String> positions = employeeDAO.GetPositions();
            //string[] positionsAsStringArray = positions.ToArray();
            comboBoxPositions.Items.AddRange(employeeDAO.GetPositions().ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            if (EmployeeId != 0)
            {
                labelEmployee.Text = "Редактирование";
                maskedTextBoxFIO.Text = employeesDataList[1];
                maskedTextBoxNumber.Text = employeesDataList[2];
                comboBoxMale.Text = employeesDataList[3];
                maskedTextBoxDateOfBirthday.Text = employeesDataList[4];
                maskedTextBoxPassport.Text = employeesDataList[5];
                maskedTextBoxAdress.Text = employeesDataList[6];
                maskedTextBoxPhone.Text = employeesDataList[7];
                comboBoxPositions.Text = employeesDataList[8];
                comboBoxPositions.SelectedItem = employeesDataList[8];
                maskedTextBoxPassword.Text = employeesDataList[9];
                maskedTextBoxSalary.Text = employeesDataList[10];

                labelPhone.Text = Filter(maskedTextBoxPhone.Text);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (EmployeeId == 0)
            {
                Employee employee = new Employee();
                employee.FIO = maskedTextBoxFIO.Text;
                employee.EmployeeNumber = maskedTextBoxNumber.Text;
                employee.Male = comboBoxMale.Text;
                //employee.DateOfBirthday = Convert.ToDateTime(maskedTextBoxDateOfBirthday.Text); 
                employee.DateOfBirthday = DateTime.ParseExact(maskedTextBoxDateOfBirthday.Text, "dd/MM/yyyy", null);
                employee.Passport = Convert.ToInt32(maskedTextBoxPassport.Text);
                employee.Adress = maskedTextBoxAdress.Text;
                employee.Phone = Filter(maskedTextBoxPhone.Text);
                employee.Position = Convert.ToInt32(comboBoxPositions.SelectedIndex) + 1;
                employee.Password = maskedTextBoxPassword.Text;
                employee.Salary = Convert.ToInt32(maskedTextBoxSalary.Text);
                labelPhone.Text = Filter(maskedTextBoxPhone.Text);
                employeeDAO.Сreate(employee);
                this.Close();
            }
            else
            {
                Employee employee = new Employee();
                employee.FIO = maskedTextBoxFIO.Text;
                employee.EmployeeNumber = maskedTextBoxNumber.Text;
                employee.Male = comboBoxMale.Text;
                //employee.DateOfBirthday = Convert.ToDateTime(maskedTextBoxDateOfBirthday.Text); 
                employee.DateOfBirthday = DateTime.ParseExact(maskedTextBoxDateOfBirthday.Text, "dd/MM/yyyy", null);
                employee.Passport = Convert.ToInt32(maskedTextBoxPassport.Text);
                employee.Adress = maskedTextBoxAdress.Text;
                employee.Phone = Filter(maskedTextBoxPhone.Text);
                employee.Position = Convert.ToInt32(comboBoxPositions.SelectedIndex) + 1;
                employee.Password = maskedTextBoxPassword.Text;
                employee.Salary = Convert.ToInt32(maskedTextBoxSalary.Text);
                employeeDAO.Update(employee, EmployeeId);
                EmployeeId = 0;
                this.Close();
            }


        }

        private void maskedTextBoxDateOfBirthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public static string Filter(string phoneNumber)
        {
            List<string> charsToRemove = new List<string>() { "(", ")", "-", " "};
            for (int i = 0; i < charsToRemove.Count; i++)
            {
                phoneNumber = phoneNumber.Replace(charsToRemove[i], "");
            }

            return phoneNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
