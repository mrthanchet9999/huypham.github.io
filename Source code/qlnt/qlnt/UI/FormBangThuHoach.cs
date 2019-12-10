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
using qlnt.DB;
using qlnt.BUS;
using Bunifu.Framework.UI;
using qlnt.UI;

namespace qlnt
{
    public partial class FormBangThuHoach : Form
    {
        BangThuHoachBUS bus = new BangThuHoachBUS();
        public FormBangThuHoach()
        {
            InitializeComponent();
            List<string> l = new List<string>() { "1","2","3","4","5","6","7","8","9","10","11","12" };
            comboBoxThang.DataSource = l;
            List<int> y = new List<int>();
            for (int i = 2015; i <= DateTime.Now.Year; i++)
                y.Add(i);
            comboBoxNam.DataSource = y;
            comboBoxNam.Text=DateTime.Now.Year.ToString();
            
        }
        internal void View()
        {
            bus.View(dataGrid);
            dataGrid.Rows[0].Selected = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            View();
        }
        // Chức năng 
        /*private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
           
            Diablog_BangTH d = new Diablog_BangTH();
            d.ShowDialog(this);
            View();
        }*/

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;

            if (dataGrid.Columns[e.ColumnIndex].Name=="Xem")
            {
                id = dataGrid.Rows[e.RowIndex].Cells["MaBang"].Value.ToString();
                //MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                Diablog_viewbangth d = new Diablog_viewbangth(id);
                d.ShowDialog(this);
                View();
            }
        }


        // Hover hàng
        private void dataGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGrid.ClearSelection();
            if(e.RowIndex > -1) {
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


        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            View();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Diablog_BangTH d = new Diablog_BangTH();
            d.ShowDialog(this);
            View();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Search(dataGrid, Convert.ToInt32(comboBoxThang.Text), Convert.ToInt32(comboBoxNam.Text));
                dataGrid.Rows[0].Selected = false;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
                View();
            }
        }
    }
}
