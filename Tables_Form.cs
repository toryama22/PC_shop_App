using Project_1.EditDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Tables_Form : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private DBServices dBServices = new DBServices();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Tables_Form()
        {
            InitializeComponent();
        }
        bool sidebarExpend;
  
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
        private void sidebarTimer_tic(object sender, EventArgs e)
        {

            //Set the Minim and maxim side of sizebar Panel
            if (sidebarExpend)
            {
                Menu_Sb.Width += 10;
                if (Menu_Sb.Width == Menu_Sb.MinimumSize.Width)
                {
                    sidebarExpend = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                Menu_Sb.Width -= 10;
                if (Menu_Sb.Width == Menu_Sb.MinimumSize.Width)
                {
                    sidebarExpend = true;
                    SideBarTimer.Stop();
                }
            }
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }


        private void btn_Home_Click(object sender, EventArgs e)
        {
          
        }


        private void btn_tables_Click(object sender, EventArgs e)
        {
            btn_tables.Enabled = false;
        }

        private void btn_requests_Click(object sender, EventArgs e)
        {
      

        }

        private void btn_Users_Click(object sender, EventArgs e)
        {
           
        }

        private void Tables_Form_Load(object sender, EventArgs e)
        {
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            new Employees_Form().Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            new Clients_Form().Show();
        }

        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            new Suppliers_Form().Show();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            new Contracts_Form().Show();
        }
    }
}
