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
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            bunifuTileButton1.Visible = false;
            bunifuTileButton2.Visible = false;
            Test test = new Test();
            test.TopLevel = false;
            this.Controls.Add(test);
            test.Show();
            bunifuTileButton1.Visible = true;
            bunifuTileButton2.Visible = true;
        }
    }
}
