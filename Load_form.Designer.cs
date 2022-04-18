
namespace Project_1
{
    partial class Load_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_Form));
            this.txtb_pass = new System.Windows.Forms.TextBox();
            this.txtb_login = new System.Windows.Forms.TextBox();
            this.Lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.AutoCont = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.AuthorizationTimer = new System.Windows.Forms.Timer(this.components);
            this.Social_Panel = new System.Windows.Forms.Panel();
            this.lb_Seti = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_Inform = new System.Windows.Forms.Label();
            this.SocialMediaTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Social_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_pass
            // 
            this.txtb_pass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb_pass.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_pass.Location = new System.Drawing.Point(107, 242);
            this.txtb_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_pass.Name = "txtb_pass";
            this.txtb_pass.PasswordChar = '*';
            this.txtb_pass.Size = new System.Drawing.Size(200, 32);
            this.txtb_pass.TabIndex = 0;
            // 
            // txtb_login
            // 
            this.txtb_login.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtb_login.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_login.Location = new System.Drawing.Point(108, 145);
            this.txtb_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtb_login.Name = "txtb_login";
            this.txtb_login.Size = new System.Drawing.Size(197, 39);
            this.txtb_login.TabIndex = 1;
            this.txtb_login.TextChanged += new System.EventHandler(this.txtb_login_TextChanged);
            // 
            // Lb_login
            // 
            this.Lb_login.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lb_login.AutoSize = true;
            this.Lb_login.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lb_login.Location = new System.Drawing.Point(119, 112);
            this.Lb_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_login.Name = "Lb_login";
            this.Lb_login.Size = new System.Drawing.Size(81, 32);
            this.Lb_login.TabIndex = 3;
            this.Lb_login.Text = "Login";
            // 
            // lb_password
            // 
            this.lb_password.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Bodoni MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_password.Location = new System.Drawing.Point(119, 196);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(122, 32);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password";
            // 
            // AutoCont
            // 
            this.AutoCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoCont.BackColor = System.Drawing.Color.Transparent;
            this.AutoCont.Controls.Add(this.pictureBox1);
            this.AutoCont.Controls.Add(this.btn_Enter);
            this.AutoCont.Controls.Add(this.Lb_login);
            this.AutoCont.Controls.Add(this.txtb_pass);
            this.AutoCont.Controls.Add(this.lb_password);
            this.AutoCont.Controls.Add(this.txtb_login);
            this.AutoCont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AutoCont.Location = new System.Drawing.Point(316, 85);
            this.AutoCont.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoCont.MaximumSize = new System.Drawing.Size(395, 350);
            this.AutoCont.MinimumSize = new System.Drawing.Size(395, 84);
            this.AutoCont.Name = "AutoCont";
            this.AutoCont.Size = new System.Drawing.Size(395, 350);
            this.AutoCont.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Enter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Enter.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(107, 290);
            this.btn_Enter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(197, 55);
            this.btn_Enter.TabIndex = 5;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // AuthorizationTimer
            // 
            this.AuthorizationTimer.Interval = 10;
            this.AuthorizationTimer.Tick += new System.EventHandler(this.AuthorizationTimer_Tick);
            // 
            // Social_Panel
            // 
            this.Social_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Social_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Social_Panel.Controls.Add(this.lb_Seti);
            this.Social_Panel.Controls.Add(this.pictureBox4);
            this.Social_Panel.Controls.Add(this.pictureBox3);
            this.Social_Panel.Controls.Add(this.pictureBox2);
            this.Social_Panel.Location = new System.Drawing.Point(393, 506);
            this.Social_Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Social_Panel.MaximumSize = new System.Drawing.Size(273, 172);
            this.Social_Panel.MinimumSize = new System.Drawing.Size(273, 71);
            this.Social_Panel.Name = "Social_Panel";
            this.Social_Panel.Size = new System.Drawing.Size(273, 71);
            this.Social_Panel.TabIndex = 8;
            // 
            // lb_Seti
            // 
            this.lb_Seti.AutoSize = true;
            this.lb_Seti.BackColor = System.Drawing.Color.Transparent;
            this.lb_Seti.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Seti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Seti.Location = new System.Drawing.Point(51, 17);
            this.lb_Seti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Seti.Name = "lb_Seti";
            this.lb_Seti.Size = new System.Drawing.Size(167, 39);
            this.lb_Seti.TabIndex = 3;
            this.lb_Seti.Text = "Мы в сети";
            this.lb_Seti.Click += new System.EventHandler(this.lb_Seti_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(185, 90);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(96, 90);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lb_Inform
            // 
            this.lb_Inform.AutoSize = true;
            this.lb_Inform.BackColor = System.Drawing.Color.Transparent;
            this.lb_Inform.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inform.ForeColor = System.Drawing.Color.Transparent;
            this.lb_Inform.Location = new System.Drawing.Point(359, 30);
            this.lb_Inform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Inform.Name = "lb_Inform";
            this.lb_Inform.Size = new System.Drawing.Size(334, 39);
            this.lb_Inform.TabIndex = 9;
            this.lb_Inform.Text = "Нажмите на картинку";
            // 
            // SocialMediaTimer
            // 
            this.SocialMediaTimer.Interval = 10;
            this.SocialMediaTimer.Tick += new System.EventHandler(this.SocialMediaTimer_Tick);
            // 
            // Load_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.lb_Inform);
            this.Controls.Add(this.Social_Panel);
            this.Controls.Add(this.AutoCont);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Load_Form";
            this.Text = "Autorisation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AutoCont.ResumeLayout(false);
            this.AutoCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Social_Panel.ResumeLayout(false);
            this.Social_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_pass;
        private System.Windows.Forms.TextBox txtb_login;
        private System.Windows.Forms.Label Lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Panel AutoCont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Timer AuthorizationTimer;
        private System.Windows.Forms.Panel Social_Panel;
        private System.Windows.Forms.Label lb_Seti;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_Inform;
        private System.Windows.Forms.Timer SocialMediaTimer;
    }
}

