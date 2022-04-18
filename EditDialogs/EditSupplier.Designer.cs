
namespace Project_1.EditDialogs
{
    partial class EditSupplier
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelCreatingSupplier = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPassport = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFIO = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxAdress = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(527, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(637, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 32);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelCreatingSupplier
            // 
            this.labelCreatingSupplier.AutoSize = true;
            this.labelCreatingSupplier.BackColor = System.Drawing.Color.Aquamarine;
            this.labelCreatingSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreatingSupplier.Location = new System.Drawing.Point(12, 9);
            this.labelCreatingSupplier.Name = "labelCreatingSupplier";
            this.labelCreatingSupplier.Size = new System.Drawing.Size(440, 29);
            this.labelCreatingSupplier.TabIndex = 24;
            this.labelCreatingSupplier.Text = "Форма создания нового поставщика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ИНН";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(132, 173);
            this.maskedTextBoxPhone.Mask = "(999) 000-00-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxPhone.TabIndex = 5;
            // 
            // maskedTextBoxPassport
            // 
            this.maskedTextBoxPassport.Location = new System.Drawing.Point(132, 63);
            this.maskedTextBoxPassport.Mask = "00000";
            this.maskedTextBoxPassport.Name = "maskedTextBoxPassport";
            this.maskedTextBoxPassport.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxPassport.TabIndex = 2;
            this.maskedTextBoxPassport.ValidatingType = typeof(int);
            // 
            // maskedTextBoxFIO
            // 
            this.maskedTextBoxFIO.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBoxFIO.Location = new System.Drawing.Point(132, 12);
            this.maskedTextBoxFIO.Name = "maskedTextBoxFIO";
            this.maskedTextBoxFIO.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxFIO.TabIndex = 0;
            // 
            // maskedTextBoxAdress
            // 
            this.maskedTextBoxAdress.Location = new System.Drawing.Point(132, 117);
            this.maskedTextBoxAdress.Name = "maskedTextBoxAdress";
            this.maskedTextBoxAdress.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxAdress.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.maskedTextBoxAdress);
            this.panel1.Controls.Add(this.maskedTextBoxFIO);
            this.panel1.Controls.Add(this.maskedTextBoxPassport);
            this.panel1.Controls.Add(this.maskedTextBoxPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(150, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 234);
            this.panel1.TabIndex = 27;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(651, 68);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(49, 17);
            this.labelPhone.TabIndex = 28;
            this.labelPhone.Text = "Phone";
            // 
            // EditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 411);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelCreatingSupplier);
            this.Name = "EditSupplier";
            this.Text = "EditSupplier";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelCreatingSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPassport;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFIO;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAdress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPhone;
    }
}