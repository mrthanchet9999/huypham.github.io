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
using qlnt.DB.Entity;

namespace qlnt.UI
{
    public partial class demo : Form
    {
        
        public demo()
        {
            InitializeComponent();
        }

        private void demo_Load(object sender, EventArgs e)
        {
            /*QLNTEntities1 db = new QLNTEntities1();
            var result = from c in db.PhanBons select new { TenPB= c.TenPB,Loai= c.Loai};
            dataGridView1.DataSource = result.ToList();*/
            PhanBon o = new PhanBon() { TenPB="hhhh"};
            textBox1.Text = o.TenPB;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Sua")
            {
                
                    //dataGridView1.CurrentRow.Selected = true;
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Ten"].Value.ToString();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
