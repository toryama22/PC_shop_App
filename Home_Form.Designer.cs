
namespace Project_1
{
    partial class Home_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Form));
            this.SideBarTimer_HomeFM = new System.Windows.Forms.Timer(this.components);
            this.Menu_Sb = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Menu = new System.Windows.Forms.Label();
            this.Menu_btn = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Home = new System.Windows.Forms.Button();
            this.tableContainer = new System.Windows.Forms.Panel();
            this.btn_tables = new System.Windows.Forms.Button();
            this.RequestsContainer = new System.Windows.Forms.Panel();
            this.btn_requests = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Users = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu_Sb.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_btn)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.RequestsContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarTimer_HomeFM
            // 
            this.SideBarTimer_HomeFM.Interval = 10;
            // 
            // Menu_Sb
            // 
            this.Menu_Sb.BackColor = System.Drawing.Color.Transparent;
            this.Menu_Sb.Controls.Add(this.panel2);
            this.Menu_Sb.Controls.Add(this.HomeContainer);
            this.Menu_Sb.Controls.Add(this.tableContainer);
            this.Menu_Sb.Controls.Add(this.RequestsContainer);
            this.Menu_Sb.Controls.Add(this.panel5);
            this.Menu_Sb.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Sb.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Sb.Location = new System.Drawing.Point(0, 0);
            this.Menu_Sb.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_Sb.MaximumSize = new System.Drawing.Size(251, 554);
            this.Menu_Sb.MinimumSize = new System.Drawing.Size(71, 554);
            this.Menu_Sb.Name = "Menu_Sb";
            this.Menu_Sb.Size = new System.Drawing.Size(251, 554);
            this.Menu_Sb.TabIndex = 8;
            this.Menu_Sb.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Sb_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lb_Menu);
            this.panel2.Controls.Add(this.Menu_btn);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 82);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lb_Menu
            // 
            this.lb_Menu.AutoSize = true;
            this.lb_Menu.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Menu.ForeColor = System.Drawing.Color.Black;
            this.lb_Menu.Location = new System.Drawing.Point(84, 25);
            this.lb_Menu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Menu.Name = "lb_Menu";
            this.lb_Menu.Size = new System.Drawing.Size(85, 36);
            this.lb_Menu.TabIndex = 1;
            this.lb_Menu.Text = "Menu";
            // 
            // Menu_btn
            // 
            this.Menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("Menu_btn.Image")));
            this.Menu_btn.Location = new System.Drawing.Point(-4, 11);
            this.Menu_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(48, 48);
            this.Menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Menu_btn.TabIndex = 0;
            this.Menu_btn.TabStop = false;
            this.Menu_btn.Click += new System.EventHandler(this.Menu_btn_Click);
            // 
            // HomeContainer
            // 
            this.HomeContainer.Controls.Add(this.panel1);
            this.HomeContainer.Location = new System.Drawing.Point(4, 94);
            this.HomeContainer.Margin = new System.Windows.Forms.Padding(4);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(227, 46);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(227, 46);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(227, 46);
            this.HomeContainer.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 49);
            this.panel1.TabIndex = 6;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(-5, -5);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Home.MaximumSize = new System.Drawing.Size(240, 49);
            this.btn_Home.MinimumSize = new System.Drawing.Size(240, 49);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(240, 49);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "            Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tableContainer
            // 
            this.tableContainer.Controls.Add(this.btn_tables);
            this.tableContainer.Location = new System.Drawing.Point(4, 148);
            this.tableContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tableContainer.MaximumSize = new System.Drawing.Size(227, 39);
            this.tableContainer.MinimumSize = new System.Drawing.Size(227, 39);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.Size = new System.Drawing.Size(227, 39);
            this.tableContainer.TabIndex = 8;
            // 
            // btn_tables
            // 
            this.btn_tables.BackColor = System.Drawing.Color.Transparent;
            this.btn_tables.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tables.ForeColor = System.Drawing.Color.Black;
            this.btn_tables.Image = ((System.Drawing.Image)(resources.GetObject("btn_tables.Image")));
            this.btn_tables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tables.Location = new System.Drawing.Point(-5, -6);
            this.btn_tables.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tables.MaximumSize = new System.Drawing.Size(240, 49);
            this.btn_tables.MinimumSize = new System.Drawing.Size(240, 49);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_tables.Size = new System.Drawing.Size(240, 49);
            this.btn_tables.TabIndex = 0;
            this.btn_tables.Text = "            Tables";
            this.btn_tables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tables.UseVisualStyleBackColor = false;
            this.btn_tables.Click += new System.EventHandler(this.btn_tables_Click);
            // 
            // RequestsContainer
            // 
            this.RequestsContainer.Controls.Add(this.btn_requests);
            this.RequestsContainer.Location = new System.Drawing.Point(4, 195);
            this.RequestsContainer.Margin = new System.Windows.Forms.Padding(4);
            this.RequestsContainer.MaximumSize = new System.Drawing.Size(227, 37);
            this.RequestsContainer.MinimumSize = new System.Drawing.Size(227, 37);
            this.RequestsContainer.Name = "RequestsContainer";
            this.RequestsContainer.Size = new System.Drawing.Size(227, 37);
            this.RequestsContainer.TabIndex = 9;
            // 
            // btn_requests
            // 
            this.btn_requests.BackColor = System.Drawing.Color.Transparent;
            this.btn_requests.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_requests.ForeColor = System.Drawing.Color.Black;
            this.btn_requests.Image = ((System.Drawing.Image)(resources.GetObject("btn_requests.Image")));
            this.btn_requests.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_requests.Location = new System.Drawing.Point(-4, -7);
            this.btn_requests.Margin = new System.Windows.Forms.Padding(4);
            this.btn_requests.MaximumSize = new System.Drawing.Size(240, 49);
            this.btn_requests.MinimumSize = new System.Drawing.Size(240, 49);
            this.btn_requests.Name = "btn_requests";
            this.btn_requests.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_requests.Size = new System.Drawing.Size(240, 49);
            this.btn_requests.TabIndex = 0;
            this.btn_requests.Text = "            Requests";
            this.btn_requests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requests.UseVisualStyleBackColor = false;
            this.btn_requests.Click += new System.EventHandler(this.btn_requests_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Users);
            this.panel5.Location = new System.Drawing.Point(4, 240);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.MaximumSize = new System.Drawing.Size(240, 49);
            this.panel5.MinimumSize = new System.Drawing.Size(227, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 41);
            this.panel5.TabIndex = 10;
            // 
            // btn_Users
            // 
            this.btn_Users.BackColor = System.Drawing.Color.Transparent;
            this.btn_Users.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Users.ForeColor = System.Drawing.Color.Black;
            this.btn_Users.Image = ((System.Drawing.Image)(resources.GetObject("btn_Users.Image")));
            this.btn_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.Location = new System.Drawing.Point(-4, -5);
            this.btn_Users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Users.MaximumSize = new System.Drawing.Size(240, 49);
            this.btn_Users.MinimumSize = new System.Drawing.Size(240, 49);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btn_Users.Size = new System.Drawing.Size(240, 49);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "            Users";
            this.btn_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.UseVisualStyleBackColor = false;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu_Sb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home_Form";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Menu_Sb.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_btn)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.RequestsContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SideBarTimer_HomeFM;
        private System.Windows.Forms.FlowLayoutPanel Menu_Sb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Menu;
        private System.Windows.Forms.PictureBox Menu_btn;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel tableContainer;
        private System.Windows.Forms.Button btn_tables;
        private System.Windows.Forms.Panel RequestsContainer;
        private System.Windows.Forms.Button btn_requests;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_Users;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}