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
    public partial class Users_Form : Form
    {
        public Users_Form()
        {
            InitializeComponent();
        }
        bool sidebarExpend;
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

        private void btn_Users_Click(object sender, EventArgs e)
        {
            btn_Users.Enabled = false;
        }

        private void btn_requests_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_tables_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
