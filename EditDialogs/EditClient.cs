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
    public partial class EditClient : Form
    {
        public int ClientId { get; set; }
        public List<String> clientsDataList = new List<string>();
        ClientDAO clientDAO = new ClientDAO();

        public EditClient()
        {
            InitializeComponent();
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            if (ClientId != 0)
            {
                labelCreatingOrEditing.Text = "Редактирование";
                maskedTextBoxFIO.Text = clientsDataList[1];
                maskedTextBoxPhone.Text = clientsDataList[2];
            }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ClientId == 0)
            {
                Client client = new Client();
                client.Fio = maskedTextBoxFIO.Text;
                client.Phone = Convert.ToInt64(EditEmployee.Filter(maskedTextBoxPhone.Text));
                clientDAO.Сreate(client);
                this.Close();
            }
            else
            {
                Client client = new Client();
                client.Fio = maskedTextBoxFIO.Text;
                client.Phone = Convert.ToInt64(EditEmployee.Filter(maskedTextBoxPhone.Text));
                clientDAO.Update(client, ClientId);
                ClientId = 0;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
