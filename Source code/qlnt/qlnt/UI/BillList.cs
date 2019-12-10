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
    public partial class BillList : Form
    {
        public BillList()
        {
            InitializeComponent();
        }

        private void ibtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
