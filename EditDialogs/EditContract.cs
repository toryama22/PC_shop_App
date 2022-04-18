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
    public partial class EditContract : Form
    {
        public int ContractId { get; set; }
        public List<string> contractsDataList = new List<string>();
        ContractDAO contractDAO = new ContractDAO();

        public EditContract()
        {
            InitializeComponent();

            Dictionary<int, string> listOfManagers = contractDAO.GetManagers();
            comboBoxManagers.DataSource = new BindingSource(listOfManagers, null);
            comboBoxManagers.ValueMember = "Key";
            comboBoxManagers.DisplayMember = "Value";

            Dictionary<int, string> listOfSuppliers = contractDAO.GetSuppliers();
            comboBoxSuppliers.DataSource = new BindingSource(listOfSuppliers, null);
            comboBoxSuppliers.ValueMember = "Key";
            comboBoxSuppliers.DisplayMember = "Value";
        }

        private void EditContract_Load(object sender, EventArgs e)
        {
            if (ContractId != 0)
            {
                maskedTextBoxNumberOfContract.Text = contractsDataList[1];
                maskedTextBoxDate.Text = contractsDataList[2];
                comboBoxManagers.SelectedItem = contractsDataList[3];
                comboBoxSuppliers.SelectedItem = contractsDataList[4];
            }
        }

        private void comboBoxManagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //labelTest.Text = comboBoxManagers.SelectedValue.ToString();
        }

        private void comboBoxSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTest.Text = comboBoxSuppliers.SelectedValue.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ContractId == 0)
            {
                Contract contract = new Contract();
                contract.NumberOfContract = Convert.ToInt32(maskedTextBoxNumberOfContract.Text);
                contract.Date = DateTime.ParseExact(maskedTextBoxDate.Text, "dd/MM/yyyy", null);
                contract.Menejer = Convert.ToInt32(comboBoxManagers.SelectedValue);
                contract.TheSupplier = Convert.ToInt32(comboBoxSuppliers.SelectedValue);
                contractDAO.Create(contract);
                this.Close();
            }
            else
            {
                Contract contract = new Contract();
                contract.NumberOfContract = Convert.ToInt32(maskedTextBoxNumberOfContract.Text);
                contract.Date = DateTime.ParseExact(maskedTextBoxDate.Text, "dd/MM/yyyy", null);
                contract.Menejer = Convert.ToInt32(comboBoxManagers.SelectedValue);
                contract.TheSupplier = Convert.ToInt32(comboBoxSuppliers.SelectedValue);
                contractDAO.Update(contract, ContractId);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
