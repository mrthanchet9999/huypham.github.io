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
using qlnt.BUS;

namespace qlnt.UI
{
    public partial class FormNhaCungCap : Form1
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        internal void View()
        {
            NhaCungCapNCCBUS bus = new NhaCungCapNCCBUS();
            bus.View(DataGrid);
            //DataGrid.Rows[0].Selected = false;

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Diablog_NCC d = new Diablog_NCC();
            d.ShowDialog();
            View();
         
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            NhaCungCapNCCBUS bus = new NhaCungCapNCCBUS();
                bus.View(DataGrid);
                View();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            string id;
            NhaCungCapNCCBUS bus = new NhaCungCapNCCBUS();
            if (DataGrid.Columns[e.ColumnIndex].Name == "Sua")
            {
                id = DataGrid.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Diablog_NCC d = new Diablog_NCC(id);
                d.ShowDialog(this);
                View();
            }
            if (DataGrid.Columns[e.ColumnIndex].Name == "Xoa")
            {
                id = DataGrid.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
                bus.Delete(id);
                View();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            NhaCungCapNCCBUS bus = new NhaCungCapNCCBUS();
            try
            {
                bus.Search(DataGrid, inputSearch.Text);
                DataGrid.Rows[0].Selected = false;
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

        private void DataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGrid.ClearSelection();
            if (e.RowIndex > -1)
            {
                DataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            }

        }

        private void DataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGrid.ClearSelection();
            if (e.RowIndex > -1)
            {
                DataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
