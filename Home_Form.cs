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
    public partial class Home_Form : Form
    {
        public Home_Form(int Id)
        {
            InitializeComponent();
            if (Id == 1) 
            {                      //Админ     
                MessageBox.Show("Welcome Admin!");
                btn_requests.Enabled = true;
                btn_tables.Enabled = true;
                btn_Users.Enabled = true;   
            }
            if (Id == 2)
            {                      //Менеджер
                MessageBox.Show("Welcome Manager!");
                btn_requests.Enabled = false;
                btn_tables.Enabled = true;
                btn_Users.Enabled = true;
            }
            if (Id == 3)                    //Продавец
            {
                MessageBox.Show("Welcome Salesman!");
                btn_requests.Enabled = false;
                btn_tables.Enabled = true;
                btn_Users.Enabled = false;
            }
            
        }

        bool sidebarExpend_HomeFM;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        private void sidebarTimer_tic(object sender, EventArgs e)
        {

            //Set the Minim and maxim side of sizebar Panel
            if (sidebarExpend_HomeFM)
            {
                Menu_Sb.Width += 10;
                if (Menu_Sb.Width == Menu_Sb.MinimumSize.Width)
                {
                    sidebarExpend_HomeFM = false;
                    SideBarTimer_HomeFM.Stop();
                }
            }
            else
            {
                Menu_Sb.Width -= 10;
                if (Menu_Sb.Width == Menu_Sb.MinimumSize.Width)
                {
                    sidebarExpend_HomeFM = true;
                    SideBarTimer_HomeFM.Stop();
                }
            }
        }   //Настройки для таймера(SideBarTimer)

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            SideBarTimer_HomeFM.Start();
        }  //Открытие менюшки


        private void btn_Home_Click(object sender, EventArgs e)                 //Не нужные кнопки отключаем
        {
            btn_Home.Enabled=false;
        }

        private void btn_tables_Click(object sender, EventArgs e)           //Открытие формы с таблицами
        {
            new Tables_Form().Show();
        }

        private void btn_requests_Click(object sender, EventArgs e)         //Открытие формы с Запросами
        {
            new Requests_Form().Show();    
        }

        private void Menu_Sb_Paint(object sender, PaintEventArgs e)
        {

        }           //Не трогать!!!

        private void btn_Users_Click(object sender, EventArgs e)            //Открытие формы с Пользователями
        {
            new Users_Form().Show();
        }

        private void btn_requests_Click_1(object sender, EventArgs e)           //Хз почему то первая не работает(...)
        {
           new Requests_Form().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

