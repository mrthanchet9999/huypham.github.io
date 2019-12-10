using qlnt.DB;
using qlnt.DialogForm;
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
    public partial class FormKeHoach : Form
    {
        KeHoachBUS bus = new KeHoachBUS();
        public FormKeHoach()
        {
            InitializeComponent();
        }
        private void View(DateTime date)
        {
            bus.View(dataGrid, date);
            try
            {
                dataGrid.Rows[0].Selected = false;
            }
            catch {
                MessageBox.Show("Không tìm thấy dữ liệu mời chọn lại thời gian");
            }
        }
        private void XemKeHoach_Load(object sender, EventArgs e)
        {
            List<int> listMonth = new List<int>() {1,2,3,4,5,6,7,8,10,11,12} ;
            comboThang.DataSource =listMonth;
            comboThang.Text = DateTime.Now.Month.ToString();
            comboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxNam.Text = DateTime.Now.Year.ToString();
            View(DateTime.Now); 
        }

        private void dataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGrid.ClearSelection();
            if (e.RowIndex > -1)
            {
                dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            }
        }

        private void dataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGrid.ClearSelection();
            if (e.RowIndex > -1)
            {
                dataGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGrid.Columns[e.ColumnIndex].Name == "Xem")
            {
                id = dataGrid.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Dialog_XemCTKH d = new Dialog_XemCTKH(id);
                d.ShowDialog(this);
                View(DateTime.Now);
            }
        }

        
        public void search()
        {
            int y = Convert.ToInt16(textBoxNam.Text);
            int m = Convert.ToInt32(comboThang.Text);
            DateTime d = new DateTime(y, m, 1);
            View(d);
        }
        private void textBoxNam_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            search();   
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Dialog_LapKeHoach d = new Dialog_LapKeHoach();
            d.ShowDialog(this);
            View(DateTime.Now);
        }
    }
}
