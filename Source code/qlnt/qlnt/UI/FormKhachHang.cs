using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlnt.UI.DialogForm;
using qlnt.DB;
using qlnt.BUS;
using Bunifu.Framework.UI;
using System.Text.RegularExpressions;

namespace qlnt.UI
{
    public partial class FormKhachHang : Form1
    {
        KhachHangBUS bus = new KhachHangBUS();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        
        internal void View()
        {
            bus.View(dataGid);
            //dataGid.Rows[0].Selected = false;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            View();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Diablog_KH d = new Diablog_KH();
            d.ShowDialog();
            View();
        }

        private void dataGid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGid.Columns[e.ColumnIndex].Name == "Sua")
            {
                id = dataGid.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Diablog_KH d = new Diablog_KH(id);
                d.ShowDialog(this);
                View();
            }
            if (dataGid.Columns[e.ColumnIndex].Name == "Xoa")
            {
                id = dataGid.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                bus.Delete(id);
                View();
            }
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                bus.Search(dataGid, inputSearch.Text);
                dataGid.Rows[0].Selected = false;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void buttonViewAll_Click_1(object sender, EventArgs e)
        {
            View();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dataGid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGid.ClearSelection();
            if (e.RowIndex > -1)
            {
                dataGid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGid.ClearSelection();
            if (e.RowIndex > -1)
            {
                dataGid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            }
        }
    }
}
