using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI
{
    public partial class ProductSellingMngmt : Form
    {
        public ProductSellingMngmt()
        {
            InitializeComponent();
        }
        private void hideComponents()
        {
            tbtnCustomerMngmt.Hide();
            tbtnSupplierMngmt.Hide();
            tbtnImportMngmt.Hide();
            tbtnExportMngmt.Hide();
            tbtnBillMngmt.Hide();
        }
        private void showComponents()
        {
            tbtnCustomerMngmt.Show();
            tbtnSupplierMngmt.Show();
            tbtnImportMngmt.Show();
            tbtnExportMngmt.Show();
            tbtnBillMngmt.Show();
        }
        private void tbtnExportMngmt_Click(object sender, EventArgs e)
        {
            ExportMngmt exportMenu = new ExportMngmt();
            exportMenu.TopLevel = false;
            this.Controls.Add(exportMenu);
            exportMenu.BringToFront();
            exportMenu.Show();
        }

        private void tbtnImportMngmt_Click(object sender, EventArgs e)
        {
            ImportMngmt importMenu = new ImportMngmt();
            importMenu.TopLevel = false;
            this.Controls.Add(importMenu);
            importMenu.BringToFront();
            importMenu.Show();
        }

        private void tbtnBillMngmt_Click(object sender, EventArgs e)
        {
            BillMngmt bill = new BillMngmt();
            bill.TopLevel = false;
            this.Controls.Add(bill);
            bill.BringToFront();
            bill.Show();
        }

        private void tbtnCustomerMngmt_Click(object sender, EventArgs e)
        {
            FormKhachHang customer = new FormKhachHang();
            customer.TopLevel = false;
            this.Controls.Add(customer);
            customer.BringToFront();
            customer.Show();
        }

        private void tbtnSupplierMngmt_Click(object sender, EventArgs e)
        {
            FormNhaCungCap supplier = new FormNhaCungCap();
            supplier.TopLevel = false;
            this.Controls.Add(supplier);
            supplier.BringToFront();
            supplier.Show();
        }
    }
}
