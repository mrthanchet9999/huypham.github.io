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
    public partial class BillMngmt : Form
    {
        public BillMngmt()
        {
            InitializeComponent();
        }

        private void hideComponents()
        {
            tbtnCreateBill.Visible = false;
            tbtnSearchBill.Visible = false;
        }

        private void showComponents()
        {
            tbtnCreateBill.Visible = true;
            tbtnSearchBill.Visible = true;
        }

        private void tbtnSearchBill_Click(object sender, EventArgs e)
        {
            BillList bill = new BillList();
            bill.TopLevel = false;
            this.Controls.Add(bill);
            bill.BringToFront();
            bill.Show();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbtnCreateBill_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.TopLevel = false;
            this.Controls.Add(bill);
            bill.BringToFront();
            bill.Show();
        }
    }
}
