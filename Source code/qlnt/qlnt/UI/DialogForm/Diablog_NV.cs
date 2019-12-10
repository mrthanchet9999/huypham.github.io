using qlnt.BUS;
using qlnt.DB;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI.DialogForm
{
    public partial class Diablog_NV : Form
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
        public Diablog_NV()
        {
            InitializeComponent();
            border();
            // An button edit
            btnEdit.Enabled = false;
            btnEdit.Visible = false;
            // Hiện button add
            btnAdd.Visible = true;
        }
        string cv;
        public Diablog_NV(string id,string chucVu)
        {
            InitializeComponent();
            border();
            // load noi dung de sua thong tin
            NhanVienDB db = new NhanVienDB();
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            NhanVien nv = db.getNhanVien(id);
            txbTenNV.Text = nv.TenNV;
            txbSoDienThoai.Text = nv.SoDienThoai;
            txbDiaChi.Text = nv.DiaChi;
            txbMatKhau.Text = nv.MatKhau;
            Quyen q = new Quyen();
            //string chucVu = dictionaryNhanVien.FirstOrDefault(c => c.Key == Convert.ToInt32(id)).Value;
            //cmbTenChucVu.Text = chucVu;
            cv = chucVu;
            #endregion
            // An button add
            btnAdd.Enabled = false;
            btnAdd.Visible = false;
            // Hiện button edit
            btnEdit.Visible = true;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Dictionary<int, string> dictionaryNhanVien = new Dictionary<int, string>();
        private void Diablog_NV_Load(object sender, EventArgs e)
        {
            NhanVienDB n = new NhanVienDB();
            // lấy danh sách cây
            dictionaryNhanVien = n.getListQuyen();
            var l = dictionaryNhanVien.Values.ToList();
            // listboxsearch chứa danh sách tìm được
            cmbTenChucVu.DataSource = l;
            cmbTenChucVu.Text = cv;

        }

        public bool check()
        {
            checkString c = new checkString();
            if (c.isNUll(txbTenNV.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbTenNV.Focus();
                return false;
            }
            if (c.isNUll(txbSoDienThoai.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbSoDienThoai.Focus();
                return false;
            }
            if (c.isNumber(txbTenNV.Text))
            {
                MessageBox.Show("Dữ liệu tên nhân viên phải là chữ");
                txbTenNV.Focus(); 
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
            if (c.isNUll(txbMatKhau.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                txbMatKhau.Focus();
                return false;
            }
            return true;
        }
        private void Dialog_close()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private int getChucVu() //lấy đối tượng muốn chọn
        {
            int id= dictionaryNhanVien.FirstOrDefault(x => x.Value == cmbTenChucVu.Text).Key;
            return id;

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            NhanVienBUS bus = new NhanVienBUS();
            if (check())
            {
                NhanVien nv = new NhanVien()
                {
                    TenNV = txbTenNV.Text,
                    SoDienThoai = txbSoDienThoai.Text,
                    DiaChi = txbDiaChi.Text,
                    MatKhau = txbMatKhau.Text,
                    MaQuyen = getChucVu()
                };

                bus.Add(nv);
                Dialog_close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (check())
            {
                NhanVien nv = new NhanVien()
                {
                    MaNV = this.id,
                    TenNV = txbTenNV.Text,
                    SoDienThoai = txbSoDienThoai.Text,
                    DiaChi = txbDiaChi.Text,
                    MatKhau = txbMatKhau.Text,
                    MaQuyen = getChucVu()

                };
                NhanVienBUS bus = new NhanVienBUS(); 
                bus.Edit(nv);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            } 
        }

        private void cmbTenChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
