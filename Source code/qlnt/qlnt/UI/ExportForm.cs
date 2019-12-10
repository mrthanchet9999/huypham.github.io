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
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
            InitializeCombobox();
        }

        private void InitializeCombobox()
        {
            cbbCustomer.Items.Add("David Dang");
            cbbCustomer.Items.Add("Hùng Vĩ Comp.");
            cbbCustomer.Items.Add("Tuấn Trương Supplier");
            cbbCustomer.Items.Add("Tù Trưởng Bộ lạc");
        }

        private void fbtnDiscardChanges_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fbtnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
