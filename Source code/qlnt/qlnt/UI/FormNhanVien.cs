using qlnt.BUS;
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

namespace qlnt.UI
{
    public partial class FormNhanVien : Form1
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        internal void View()
        {
            NhanVienBUS bus = new NhanVienBUS();
            bus.View(DataGird);
            //DataGird.Rows[0].Selected = false;

        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            View();
        }

        private void DataGird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            NhanVienBUS bus = new NhanVienBUS();
            if (DataGird.Columns[e.ColumnIndex].Name == "Sua")
            {
                id = DataGird.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                string cv = DataGird.Rows[e.RowIndex].Cells["TenChucVu"].Value.ToString();
                Diablog_NV d = new Diablog_NV(id,cv);
                d.ShowDialog(this);
                View();
            }

            if (DataGird.Columns[e.ColumnIndex].Name == "Xoa")
            {
                id = DataGird.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                bus.Delete(id);
                View();
            }
        }

            private void buttonAdd_Click(object sender, EventArgs e)
        {
            Diablog_NV d = new Diablog_NV();
            d.ShowDialog();
            View();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            NhanVienBUS bus = new NhanVienBUS();
            try
            {
                bus.Search(DataGird, inputSearch.Text);
                DataGird.Rows[0].Selected = false;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            View();
        }

        // Hover hàng
        private void DataGird_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGird.ClearSelection();
            if (e.RowIndex > -1)
            {
                DataGird.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            }
        }

        private void DataGird_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGird.ClearSelection();
            if (e.RowIndex > -1)
            {
                DataGird.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
