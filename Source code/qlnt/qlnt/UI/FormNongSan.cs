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
    public partial class FormNongSan : Form1
    {
        NongSanBUS bus = new NongSanBUS();
        public FormNongSan()
        {
            InitializeComponent();

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
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Diablog_NS d = new Diablog_NS();
            d.ShowDialog(this);
            View();
        }

     


        // Hover hàng
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Search(dataGrid, inputSearch.Text);
                dataGrid.Rows[0].Selected = false;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
                View();
            }
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            View();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGrid.Columns[e.ColumnIndex].Name == "Sua")
            {
                /*MessageBox.Show("gg");
                MessageBox.Show(dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                id = dataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                
                Diablog_NS d = new Diablog_NS(id);
                d.ShowDialog(this);
                View();*/
                id = dataGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();

                Diablog_NS d = new Diablog_NS(id);
                d.ShowDialog(this);
                View();
            }
        }
    }
}
