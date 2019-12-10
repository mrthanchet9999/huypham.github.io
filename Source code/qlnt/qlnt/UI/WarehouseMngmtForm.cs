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
    public partial class WarehouseMngmtForm : Form
    {
        public WarehouseMngmtForm()
        {
            InitializeComponent();
        }

        private void hideComponents()
        {
            tbtnFertilizerMngmt.Visible = false;
            tbtnPesticideMngmt.Visible = false;
            tbtnProductMngmt.Visible = false;
        } 
        private void showComponents ()
        {
            tbtnFertilizerMngmt.Visible = true;
            tbtnPesticideMngmt.Visible = true;
            tbtnProductMngmt.Visible = true;
        }
        private void tbtnPesticideMngmt_Click(object sender, EventArgs e)
        {
            hideComponents();
            FormThuocBaoVeTV pesticide = new FormThuocBaoVeTV();
            pesticide.TopLevel = false;
            this.Controls.Add(pesticide);
            pesticide.Show();
            pesticide.BringToFront();
            showComponents();
        }

        

        private void tbtnFertilizerMngmt_Click(object sender, EventArgs e)
        {
            hideComponents();
            FormPhanBon fertilizer = new FormPhanBon();
            fertilizer.TopLevel = false;
            this.Controls.Add(fertilizer);
            fertilizer.Show();
            fertilizer.BringToFront();
            showComponents();
        }

        private void tbtnProductMngmt_Click(object sender, EventArgs e)
        {
            hideComponents();
            FormNongSan product = new FormNongSan();
            product.TopLevel = false;
            this.Controls.Add(product);
            product.Show();
            product.BringToFront();
            showComponents();
        }
    }
}
