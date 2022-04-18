
namespace Project_1.EditDialogs
{
    partial class EditContract
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
            this.maskedTextBoxNumberOfContract = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.comboBoxManagers = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.Location = new System.Drawing.Point(551, 381);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 32);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Location = new System.Drawing.Point(661, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 32);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelCreatingSupplier
            // 
            this.labelCreatingSupplier.AutoSize = true;
            this.labelCreatingSupplier.BackColor = System.Drawing.Color.Aquamarine;
            this.labelCreatingSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreatingSupplier.Location = new System.Drawing.Point(36, 38);
            this.labelCreatingSupplier.Name = "labelCreatingSupplier";
            this.labelCreatingSupplier.Size = new System.Drawing.Size(440, 29);
            this.labelCreatingSupplier.TabIndex = 29;
            this.labelCreatingSupplier.Text = "Форма создания нового поставщика";
            // 
            // maskedTextBoxNumberOfContract
            // 
            this.maskedTextBoxNumberOfContract.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.maskedTextBoxNumberOfContract.Location = new System.Drawing.Point(179, 9);
            this.maskedTextBoxNumberOfContract.Mask = "00000";
            this.maskedTextBoxNumberOfContract.Name = "maskedTextBoxNumberOfContract";
            this.maskedTextBoxNumberOfContract.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxNumberOfContract.TabIndex = 0;
            this.maskedTextBoxNumberOfContract.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер контракта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Поставщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Менеджер";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.comboBoxSuppliers);
            this.panel1.Controls.Add(this.comboBoxManagers);
            this.panel1.Controls.Add(this.maskedTextBoxDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.maskedTextBoxNumberOfContract);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(174, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 234);
            this.panel1.TabIndex = 32;
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(179, 173);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.Size = new System.Drawing.Size(205, 24);
            this.comboBoxSuppliers.TabIndex = 18;
            this.comboBoxSuppliers.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuppliers_SelectedIndexChanged);
            // 
            // comboBoxManagers
            // 
            this.comboBoxManagers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManagers.FormattingEnabled = true;
            this.comboBoxManagers.Location = new System.Drawing.Point(179, 117);
            this.comboBoxManagers.Name = "comboBoxManagers";
            this.comboBoxManagers.Size = new System.Drawing.Size(205, 24);
            this.comboBoxManagers.TabIndex = 17;
            this.comboBoxManagers.SelectedIndexChanged += new System.EventHandler(this.comboBoxManagers_SelectedIndexChanged);
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Location = new System.Drawing.Point(179, 63);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(205, 22);
            this.maskedTextBoxDate.TabIndex = 15;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Дата создания";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTest.Location = new System.Drawing.Point(623, 73);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(52, 17);
            this.labelTest.TabIndex = 33;
            this.labelTest.Text = "label2";
            // 
            // EditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelCreatingSupplier);
            this.Controls.Add(this.panel1);
            this.Name = "EditContract";
            this.Text = "EditContract";
            this.Load += new System.EventHandler(this.EditContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelCreatingSupplier;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberOfContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.ComboBox comboBoxManagers;
        private System.Windows.Forms.Label labelTest;
    }
}