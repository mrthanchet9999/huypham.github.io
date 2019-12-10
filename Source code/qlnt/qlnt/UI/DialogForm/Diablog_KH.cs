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

namespace qlnt.UI
{
       
    public partial class Diablog_KH : Form
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
        KhachHangBUS bus = new KhachHangBUS();
        int id;
        public Diablog_KH()
        {
            InitializeComponent();
            border();
        }
        public Diablog_KH(string id)
        {
            InitializeComponent();
            border();
            // load noi dung de sua thong tin
            KhachHangDB db = new KhachHangDB();
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            KhachHang kh = db.getKhachHang(id);
            txbTenKH.Text = kh.TenKH;
            txbDienThoai.Text = kh.DienThoai;
            txbDiaChi.Text = kh.DiaChi;
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
            if (c.isNUll(txbTenKH.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbTenKH.Focus();
                return false;
            }
            if (c.isNUll(txbDienThoai.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbDienThoai.Focus();
                return false;
            }
            if (!c.isNumber(txbDienThoai.Text))
            {
                MessageBox.Show("Dữ liệu phải là số");
                txbDienThoai.Focus();
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
        private void Diablog_KH_Load(object sender, EventArgs e)
        {
        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                KhachHang kh = new KhachHang()
                {
                    TenKH = txbTenKH.Text,
                    DienThoai = txbDienThoai.Text,
                    DiaChi = txbDiaChi.Text
                };
                    bus.Add(kh);
                    Dialog_close();
            }
        }
        private void Dialog_close()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (check())
            {
                KhachHang kh = new KhachHang()
                {
                    MaKH = this.id,
                    TenKH = txbTenKH.Text,
                    DienThoai = txbDienThoai.Text,
                    DiaChi = txbDiaChi.Text
                };
                bus.Edit(kh);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }
    }
}
