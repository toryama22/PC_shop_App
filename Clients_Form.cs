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
    public partial class Clients_Form : Form
    {
        private ClientDAO clientDAO = new ClientDAO();
        private List<String> clientsDataList = new List<string>();

        public Clients_Form()
        {
            InitializeComponent();
            this.ClientsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ClientsTable.MultiSelect = false;
        }

        private void Clients_Form_Load(object sender, EventArgs e)
        {
            ClientsTable.DataSource = clientDAO.GetAllClients();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditClient editClient = new EditClient();
            editClient.ShowDialog();
            ClientsTable.DataSource = clientDAO.GetAllClients();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedCellCount = ClientsTable.GetCellCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedCellCount; i++)
            {
                clientsDataList.Add(ClientsTable.CurrentRow.Cells[i].Value.ToString());
            }   

            EditClient editClient = new EditClient();
            editClient.ClientId = Convert.ToInt32(clientsDataList[0]);
            editClient.clientsDataList = clientsDataList;
            editClient.ShowDialog();
            ClientsTable.DataSource = clientDAO.GetAllClients();
            clientsDataList.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ClientsTable.CurrentRow.Cells[0].Value.ToString());
            clientDAO.Delete(id);
            ClientsTable.DataSource = clientDAO.GetAllClients();
        }
    }
}
