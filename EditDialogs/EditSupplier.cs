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
    public partial class EditSupplier : Form
    {
        public int SupplierId { get; set; }
        public List<string> suppliersDataList = new List<string>();
        SupplierDAO supplierDAO = new SupplierDAO();

        public EditSupplier()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            if (SupplierId != 0)
            {
                labelCreatingSupplier.Text = "Редактирование";
                maskedTextBoxFIO.Text = suppliersDataList[1];
                maskedTextBoxPassport.Text = suppliersDataList[2];
                maskedTextBoxAdress.Text = suppliersDataList[3];
                maskedTextBoxPhone.Text = suppliersDataList[4];
            }
        }

        private void maskedTextBoxSalary_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SupplierId == 0)
            {
                Supplier supplier = new Supplier();
                supplier.FIO = maskedTextBoxFIO.Text;
                supplier.INN = Convert.ToInt32(maskedTextBoxPassport.Text);
                supplier.Adress = maskedTextBoxAdress.Text;
                supplier.Phone = Convert.ToInt64(EditEmployee.Filter(maskedTextBoxPhone.Text).Trim());
                supplierDAO.create(supplier);
                this.Close();
            }
            else
            {
                Supplier supplier = new Supplier();
                supplier.FIO = maskedTextBoxFIO.Text;
                supplier.INN = Convert.ToInt32(maskedTextBoxPassport.Text);
                supplier.Adress = maskedTextBoxAdress.Text;
                supplier.Phone = Convert.ToInt64(EditEmployee.Filter(maskedTextBoxPhone.Text).Trim());
                supplierDAO.update(supplier, SupplierId);
                SupplierId = 0;
                this.Close();
            }
            
            //labelPhone.Text = EditEmployee.Filter(maskedTextBoxPhone.Text).Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
