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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            
        }

        private void fbtnDiscard_Click(object sender, EventArgs e)
        {
            this.Hide();
            dpDate.Format = DateTimePickerFormat.Custom;
            dpDate.FormatCustom = "dd/MM/yyyy";
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            
        }

        private void fbtnDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
