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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }
        private void hideComponents()
        {
            tbtnFinancialStatistics.Visible = false;
            tbtnSellingStatistics.Visible = false;
            tbtnWarehouseStatistics.Visible = false;
        }

        private void showComponents()
        {
            tbtnFinancialStatistics.Visible = true;
            tbtnSellingStatistics.Visible = true;
            tbtnWarehouseStatistics.Visible = true;
        }

        private void tbtnWarehouseStatistics_Click(object sender, EventArgs e)
        {
            FormQuanLyKho ware = new FormQuanLyKho();
            ware.TopLevel = false;
            this.Controls.Add(ware);
            ware.Show();
            ware.BringToFront();
        }

        private void tbtnSellingStatistics_Click(object sender, EventArgs e)
        {
            FormThongKeSanLuong productamount = new FormThongKeSanLuong();
            productamount.TopLevel = false;
            this.Controls.Add(productamount);
            productamount.BringToFront();
            productamount.Show();
        }

        private void tbtnFinancialStatistics_Click(object sender, EventArgs e)
        {
            FormThongKeDoanhThuTheoNam sellrate = new FormThongKeDoanhThuTheoNam();
            sellrate.TopLevel = false;
            this.Controls.Add(sellrate);
            sellrate.BringToFront();
            sellrate.Show();
        }
    }
}
