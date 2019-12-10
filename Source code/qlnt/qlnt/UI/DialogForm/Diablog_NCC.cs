using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlnt.BUS;
using qlnt.DB;
using qlnt.DB.Entity;

namespace qlnt.UI.DialogForm
{
    public partial class Diablog_NCC : Form
    {
        #region di chuyển dialog
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        #endregion

        #region border
        public void border()
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        #endregion
        int id;
        public Diablog_NCC()
        {
            InitializeComponent();
            border();
            // An button edit
            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            // Hiện button add
            btnAdd.Visible = true;
        }

        public Diablog_NCC(string id)
        {
                InitializeComponent();
            border();
                // load noi dung de sua thong tin
                NhaCungCapDB db = new NhaCungCapDB();
                #region gắn giá trị
                this.id = Convert.ToInt32(id);
                NhaCungCap ncc = db.getNhaCungCap(id);
                txbTenNCC.Text = ncc.TenNCC;
                txbSoDienThoai.Text = ncc.SoDienThoai;
                txbDiaChi.Text = ncc.DiaChi;
                #endregion
                // An button add
                btnAdd.Enabled = false;
                btnAdd.Visible = false;
                // Hiện button edit
                btnEdit.Visible = true;
        }

        public bool check()
        {
            checkString c = new checkString();
            if (c.isNUll(txbTenNCC.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbTenNCC.Focus();
                return false;
            }
            if (c.isNUll(txbSoDienThoai.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbSoDienThoai.Focus();
                return false;
            }
            if (!c.isNumber(txbSoDienThoai.Text))
            {
                MessageBox.Show("Dữ liệu phải là số");
                txbSoDienThoai.Focus();
                return false;
            }
            if (c.isNUll(txbDiaChi.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbDiaChi.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhaCungCapNCCBUS bus = new NhaCungCapNCCBUS();
            if (check())
            {
                 NhaCungCap ncc = new NhaCungCap()
                {
                    TenNCC = txbTenNCC.Text,
                    SoDienThoai = txbSoDienThoai.Text,
                    DiaChi = txbDiaChi.Text
                };
                bus.Add(ncc);
                Dialog_close();
            }
        }
        private void Dialog_close()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Diablog_NCC_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (check())
            {
                NhaCungCapNCCBUS bus = new NhaCungCapNCCBUS();
                NhaCungCap ncc = new NhaCungCap()
                {
                    MaNCC = this.id,
                    TenNCC = txbTenNCC.Text,
                    SoDienThoai = txbSoDienThoai.Text,
                    DiaChi = txbDiaChi.Text
                };
                bus.Edit(ncc);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }

    }
}
