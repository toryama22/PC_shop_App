
namespace Project_1
{
    partial class Users_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users_Form));
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
            this.SideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.Menu_Sb.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_btn)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableContainer.SuspendLayout();
            this.RequestsContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
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
            this.Menu_Sb.MaximumSize = new System.Drawing.Size(158, 450);
            this.Menu_Sb.MinimumSize = new System.Drawing.Size(53, 450);
            this.Menu_Sb.Name = "Menu_Sb";
            this.Menu_Sb.Size = new System.Drawing.Size(53, 450);
            this.Menu_Sb.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lb_Menu);
            this.panel2.Controls.Add(this.Menu_btn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 67);
            this.panel2.TabIndex = 7;
            // 
            // lb_Menu
            // 
            this.lb_Menu.AutoSize = true;
            this.lb_Menu.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Menu.ForeColor = System.Drawing.Color.Black;
            this.lb_Menu.Location = new System.Drawing.Point(63, 20);
            this.lb_Menu.Name = "lb_Menu";
            this.lb_Menu.Size = new System.Drawing.Size(69, 29);
            this.lb_Menu.TabIndex = 1;
            this.lb_Menu.Text = "Menu";
            // 
            // Menu_btn
            // 
            this.Menu_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("Menu_btn.Image")));
            this.Menu_btn.Location = new System.Drawing.Point(-3, 9);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(48, 48);
            this.Menu_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Menu_btn.TabIndex = 0;
            this.Menu_btn.TabStop = false;
            // 
            // HomeContainer
            // 
            this.HomeContainer.Controls.Add(this.panel1);
            this.HomeContainer.Location = new System.Drawing.Point(3, 76);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(170, 37);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(170, 37);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(170, 37);
            this.HomeContainer.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 40);
            this.panel1.TabIndex = 6;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(-4, -4);
            this.btn_Home.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_Home.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(180, 40);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "            Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // tableContainer
            // 
            this.tableContainer.Controls.Add(this.btn_tables);
            this.tableContainer.Location = new System.Drawing.Point(3, 119);
            this.tableContainer.MaximumSize = new System.Drawing.Size(170, 32);
            this.tableContainer.MinimumSize = new System.Drawing.Size(170, 32);
            this.tableContainer.Name = "tableContainer";
            this.tableContainer.Size = new System.Drawing.Size(170, 32);
            this.tableContainer.TabIndex = 8;
            // 
            // btn_tables
            // 
            this.btn_tables.BackColor = System.Drawing.Color.Transparent;
            this.btn_tables.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tables.ForeColor = System.Drawing.Color.Black;
            this.btn_tables.Image = ((System.Drawing.Image)(resources.GetObject("btn_tables.Image")));
            this.btn_tables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tables.Location = new System.Drawing.Point(-4, -5);
            this.btn_tables.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_tables.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_tables.Name = "btn_tables";
            this.btn_tables.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_tables.Size = new System.Drawing.Size(180, 40);
            this.btn_tables.TabIndex = 0;
            this.btn_tables.Text = "            Tables";
            this.btn_tables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tables.UseVisualStyleBackColor = false;
            this.btn_tables.Click += new System.EventHandler(this.btn_tables_Click);
            // 
            // RequestsContainer
            // 
            this.RequestsContainer.Controls.Add(this.btn_requests);
            this.RequestsContainer.Location = new System.Drawing.Point(3, 157);
            this.RequestsContainer.MaximumSize = new System.Drawing.Size(170, 30);
            this.RequestsContainer.MinimumSize = new System.Drawing.Size(170, 30);
            this.RequestsContainer.Name = "RequestsContainer";
            this.RequestsContainer.Size = new System.Drawing.Size(170, 30);
            this.RequestsContainer.TabIndex = 9;
            // 
            // btn_requests
            // 
            this.btn_requests.BackColor = System.Drawing.Color.Transparent;
            this.btn_requests.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_requests.ForeColor = System.Drawing.Color.Black;
            this.btn_requests.Image = ((System.Drawing.Image)(resources.GetObject("btn_requests.Image")));
            this.btn_requests.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_requests.Location = new System.Drawing.Point(-3, -6);
            this.btn_requests.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_requests.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_requests.Name = "btn_requests";
            this.btn_requests.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_requests.Size = new System.Drawing.Size(180, 40);
            this.btn_requests.TabIndex = 0;
            this.btn_requests.Text = "            Requests";
            this.btn_requests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_requests.UseVisualStyleBackColor = false;
            this.btn_requests.Click += new System.EventHandler(this.btn_requests_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Users);
            this.panel5.Location = new System.Drawing.Point(3, 193);
            this.panel5.MaximumSize = new System.Drawing.Size(180, 40);
            this.panel5.MinimumSize = new System.Drawing.Size(170, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(170, 33);
            this.panel5.TabIndex = 10;
            // 
            // btn_Users
            // 
            this.btn_Users.BackColor = System.Drawing.Color.Transparent;
            this.btn_Users.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Users.ForeColor = System.Drawing.Color.Black;
            this.btn_Users.Image = ((System.Drawing.Image)(resources.GetObject("btn_Users.Image")));
            this.btn_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.Location = new System.Drawing.Point(-3, -4);
            this.btn_Users.MaximumSize = new System.Drawing.Size(180, 40);
            this.btn_Users.MinimumSize = new System.Drawing.Size(180, 40);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Users.Size = new System.Drawing.Size(180, 40);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "            Users";
            this.btn_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.UseVisualStyleBackColor = false;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // SideBarTimer
            // 
            this.SideBarTimer.Interval = 10;
            // 
            // Users_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu_Sb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users_Form";
            this.Text = "Users";
            this.Menu_Sb.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_btn)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableContainer.ResumeLayout(false);
            this.RequestsContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Timer SideBarTimer;
    }
}