using Project_1.EditDialogs;
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

namespace Project_1
{
    public partial class Suppliers_Form : Form
    {
        private SupplierDAO supplierDAO = new SupplierDAO();
        private List<string> suppliersDataList = new List<string>();

        public Suppliers_Form()
        {
            InitializeComponent();
            this.SuppliersTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.SuppliersTable.MultiSelect = false;
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            SuppliersTable.DataSource = supplierDAO.GetAllSuppliers();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            EditSupplier editSupplier = new EditSupplier();
            editSupplier.ShowDialog();
            SuppliersTable.DataSource = supplierDAO.GetAllSuppliers();
        }


        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            int selectedCellCount = SuppliersTable.GetCellCount(DataGridViewElementStates.Selected);
            for (int i = 0; i < selectedCellCount; i++)
            {
                suppliersDataList.Add(SuppliersTable.CurrentRow.Cells[i].Value.ToString());
            }

            EditSupplier editSupplier = new EditSupplier();
            editSupplier.SupplierId = Convert.ToInt32(suppliersDataList[0]);
            editSupplier.suppliersDataList = suppliersDataList;
            editSupplier.ShowDialog();
            SuppliersTable.DataSource = supplierDAO.GetAllSuppliers();
            suppliersDataList.Clear();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(SuppliersTable.CurrentRow.Cells[0].Value.ToString());
            supplierDAO.delete(id);
            SuppliersTable.DataSource = supplierDAO.GetAllSuppliers();
        }
    }
}