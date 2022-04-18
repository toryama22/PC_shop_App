using Project_1.EditDialogs;
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

namespace Project_1
{
    public partial class Contracts_Form : Form
    {
        private ContractDAO contractDAO = new ContractDAO();
        private List<string> contractsDataList = new List<string>();
        
        public Contracts_Form()
        {
            InitializeComponent();
            ContractsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContractsTable.MultiSelect = false;
        }

        private void Contracts_Form_Load(object sender, EventArgs e)
        {
            ContractsTable.DataSource = contractDAO.GetAllContracts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditContract editContract = new EditContract();
            editContract.ShowDialog();
            ContractsTable.DataSource = contractDAO.GetAllContracts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedCellCount = ContractsTable.GetCellCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedCellCount; i++)
            {
                contractsDataList.Add(ContractsTable.CurrentRow.Cells[i].Value.ToString());
            }

            EditContract editContract = new EditContract();
            editContract.ContractId = Convert.ToInt32(contractsDataList[0]);
            editContract.contractsDataList = contractsDataList;
            editContract.ShowDialog();
            ContractsTable.DataSource = contractDAO.GetAllContracts();
            contractsDataList.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ContractsTable.CurrentRow.Cells[0].Value.ToString());
            contractDAO.Delete(id);
            ContractsTable.DataSource = contractDAO.GetAllContracts();
        }
    }
}
