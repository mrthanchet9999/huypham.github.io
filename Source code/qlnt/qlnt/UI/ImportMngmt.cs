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
    public partial class ImportMngmt : Form
    {
        public ImportMngmt()
        {
            InitializeComponent();
        }

        private void tbtnImportSearch_Click(object sender, EventArgs e)
        {
            ImportFormList impf = new ImportFormList();
            impf.TopLevel = false;
            this.Controls.Add(impf);
            impf.BringToFront();
            impf.Show();
        }

        private void tbtnCreateImpf_Click(object sender, EventArgs e)
        {
            ImportForm impf = new ImportForm();
            impf.TopLevel = false;
            this.Controls.Add(impf);
            impf.BringToFront();
            impf.Show();
        }
        private void hideComponents()
        {
            tbtnCreateImpf.Visible = false;
            tbtnSearchImpf.Visible = false;
        }

        private void showComponents()
        {
            tbtnCreateImpf.Visible = true;
            tbtnSearchImpf.Visible = true;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
