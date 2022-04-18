using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Project_1
{
    public partial class Load_Form : Form
    {
        public Load_Form()
        {
            InitializeComponent();
        }


     
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        bool AutCollapsed;
        bool Socialmedia;



        private void AuthorizationTimer_Tick(object sender, EventArgs e)
        {
            if (AutCollapsed)
            {
                AutoCont.Height += 10;
                if (AutoCont.Height == AutoCont.MaximumSize.Height)
                {
                    AutCollapsed = false;
                    AuthorizationTimer.Stop();
                }


            }
            else {
                AutoCont.Height -= 10;
                if (AutoCont.Height == AutoCont.MinimumSize.Height)
                {
                    AutCollapsed = true;
                    AuthorizationTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AuthorizationTimer.Start();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int Id;
            string user = txtb_login.Text;
            string password = txtb_pass.Text;
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=.;Initial Catalog=Project_1_Sp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string query = $"Select * from Employees where Position = N'{txtb_login.Text.Trim()}' and password = N'{txtb_pass.Text.Trim()}'";

                Id = Convert.ToInt32(txtb_login.Text);
                Home_Form newForm = new Home_Form(Id);
                SqlDataAdapter sda = new SqlDataAdapter(query, sql);
                DataTable table = new DataTable();
                sda.Fill(table);
                if (table.Rows.Count == 1)
                {
                    newForm.Show();
                    this.Visible = false;
                }
                else
                    MessageBox.Show("Chek your username and password!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error = " + ex);

            }
        }

        private void lb_Seti_Click(object sender, EventArgs e)
        {
            SocialMediaTimer.Start();
        }

        private void SocialMediaTimer_Tick(object sender, EventArgs e)
        {
            if (Socialmedia)
            {
                Social_Panel.Height += 50;
                if (Social_Panel.Height == Social_Panel.MaximumSize.Height)
                {
                    Socialmedia = false;
                    SocialMediaTimer.Stop();
                }


            }
            else
            {
                Social_Panel.Height -= 50;
                if (Social_Panel.Height == Social_Panel.MinimumSize.Height)
                {
                    Socialmedia = true;
                    SocialMediaTimer.Stop();
                }
            }
        }

        private void txtb_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
