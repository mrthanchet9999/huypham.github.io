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
using System.Text.RegularExpressions;
using qlnt.BUS;
using qlnt.UI.DialogForm;

namespace qlnt.DialogForm
{
  
    public partial class Diablog_BangTH : Form, InterfaceDialog
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
        BangThuHoachBUS bus = new BangThuHoachBUS();
        BangThuHoach o;
        int id;
        Dictionary<int, string> dNS;
        Dictionary<int, string> dNV;
        List<ChiTiet_TH> listCtTH = new List<ChiTiet_TH>();
        public Diablog_BangTH()
        {
            InitializeComponent();
            border();
            hide_button_luu();
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                dNS= (
                    from ns in db.NongSan join c in db.Cay on ns.MaLoaiCay equals c.MaLoaiCay
                    select new { ns.MaNS, c.TenCay }

                    ).ToDictionary(ns => ns.MaNS, c => c.TenCay);
            }
            comboBoxTenCay.DataSource = dNS.Values.ToList();
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                dNV = (
                    from c in db.NhanVien
                    select new { c.MaNV, c.TenNV }

                    ).ToDictionary(c => c.MaNV, c => c.TenNV);
            }
            comboBoxTenNV.DataSource = dNV.Values.ToList();
        }
        public Diablog_BangTH(string id)
        {
            InitializeComponent();
            border();
            BangThuHoachDB db = new BangThuHoachDB();
            // load noi dung de sua thong tin
            Dictionary<int, string> d;
            using (QLNTEntities1 db1 = new QLNTEntities1())
            {
                d = (
                    from c in db1.Cay
                    select new { c.MaLoaiCay, c.TenCay }

                    ).ToDictionary(c => c.MaLoaiCay, c => c.TenCay);
            }
            comboBoxTenCay.DataSource = d.Values.ToList();
            using (QLNTEntities1 db1 = new QLNTEntities1())
            {
                d = (
                    from c in db1.NhanVien
                    select new { c.MaNV, c.TenNV }

                    ).ToDictionary(c => c.MaNV, c => c.TenNV);
            }
            comboBoxTenNV.DataSource = d.Values.ToList();
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.GetBangThuHoach(id);
            //textSanLuongThuHoach.Text = o..ToString();
           // DatepickerNgayThuHoach.Value.ToString("dd/MM/yyyy");
            #endregion
            
            //Hien button luu
            button_luu.Visible = true;
            //button_luu.Enabled = false;
        }
        public bool check()
        {
            checkString c = new checkString();
            if (c.isNUll(comboBoxTenCay.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                comboBoxTenCay.Focus();
                return false;
            }
            if (c.isNUll(comboBoxTenNV.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                comboBoxTenNV.Focus();
                return false;
            }
            if (!c.isNumber(textSanLuongThuHoach.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSanLuongThuHoach.Focus();
                return false;
            }
            if (!c.isNumber(textSanLuongThietHai.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSanLuongThietHai.Focus();
                return false;
            }
            if (Convert.ToInt32(textSanLuongThietHai.Text)>Convert.ToInt32(textSanLuongThuHoach.Text))
            {
                MessageBox.Show("Sản lượng thiệt hại không thể lớn hơn sản lượng thu hoạch! ");
                textSanLuongThietHai.Focus();
                return false;
            }
            return true;
        }
        private void Dialog_close()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /*private void add_PB_Load(object sender, EventArgs e)
        {
            List<string> l=new List<string>() {"Xuân", "Hạ", "Thu", "Đông" } ;
            comboBoxMuaThuHoach.DataSource = l;
            //DatepickerSX.Format = DateTimePickerFormat.Custom;
            //DatepickerSX.FormatCustom = "dd/MM/yyyy";

        }*/

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
      
       

        private void labelTen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Diablog_BangTH_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        List<string> luucb = new List<string>();
        int index_row = 0;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (check())
            {
                QLNTEntities1 db = new QLNTEntities1();
                ChiTiet_TH temp = new ChiTiet_TH();
                //var luucbb  = comboBoxTenCay.Text;
                int maNS = dNS.FirstOrDefault(c => c.Value == comboBoxTenCay.Text).Key;
                luucb.Add(comboBoxTenCay.Text);
                temp.MaNS = maNS;
                temp.SanLuongThuHoach = Convert.ToDouble(textSanLuongThuHoach.Text);
                temp.SanLuongThietHai = Convert.ToDouble(textSanLuongThietHai.Text);
                listCtTH.Add(temp);

                var result = from c in listCtTH join ns in db.NongSan on c.MaNS equals ns.MaNS join p in db.Cay on ns.MaLoaiCay equals p.MaLoaiCay
                             select new { MaNS=c.MaNS,TenCay= p.TenCay,SanLuongThuHoach=c.SanLuongThuHoach, SanLuongThietHai=c.SanLuongThietHai} ;
                dataGrid.DataSource = result.ToList();
                index_row = index_row + 1;
                setTextNull();
                comboBoxTenCay.DataSource = null;
                comboBoxTenCay.Items.Clear();
                foreach ( var item in dNS)
                {
                    comboBoxTenCay.Items.Add(item.Value);
                    foreach (var str in luucb)
                    {
                        if(item.Value==str)
                        {
                            comboBoxTenCay.Items.Remove(item.Value);
                        }
                    }
                }
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            int id = 0;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                BangThuHoach b = new BangThuHoach();
                b.NgayThuHoach = DateTime.Now;
                b.MaNV = dNV.SingleOrDefault(c => c.Value == comboBoxTenNV.Text).Key;
                db.BangThuHoach.Add(b);
                db.SaveChanges();
                db.Entry(b).GetDatabaseValues();
                id = b.MaBang;
            }
            /// 
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                foreach (var item in listCtTH)
                {
                    item.MaBang = id;
                    db.ChiTiet_TH.Add(item);
                }
                db.SaveChanges();
            }
            this.Close();
            bus.View(dataGrid);

        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (check())
            {
                QLNTEntities1 db = new QLNTEntities1();
                var id = dNS.FirstOrDefault(temp => temp.Value == comboBoxTenCay.Text).Key;
                foreach (var item in listCtTH)
                {
                    if (item.MaNS == id)
                    {
                        item.SanLuongThuHoach = Convert.ToDouble(textSanLuongThuHoach.Text);
                        item.SanLuongThietHai = Convert.ToDouble(textSanLuongThietHai.Text);
                        break;
                    }
                }
                MessageBox.Show("Sửa thành công");
                var result = from c in listCtTH
                             join ns in db.NongSan on c.MaNS equals ns.MaNS
                             join p in db.Cay on ns.MaLoaiCay equals p.MaLoaiCay
                             select new { MaNS = c.MaNS, TenCay = p.TenCay, SanLuongThuHoach = c.SanLuongThuHoach, SanLuongThietHai = c.SanLuongThietHai };
                dataGrid.DataSource = result.ToList();
                setTextNull();
                show_button_add();
                hide_button_luu();
                comboBoxTenCay.Enabled = true;
            }

        }
        private void setTextNull()
        {
            textSanLuongThuHoach.Text = null;
            textSanLuongThietHai.Text = null;
            comboBoxTenCay.Text = null;
        }
        private void hide_button_luu()
        {
            bunifuImageButton3.Visible = false;
            label8.Visible = false;
        }
        private void hide_button_add()
        {
            bunifuImageButton2.Visible = false;
            label4.Visible = false;
        }
        private void show_button_luu()
        {
            bunifuImageButton3.Visible = true;
            label8.Visible = true;
        }
        private void show_button_add()
        {
            bunifuImageButton2.Visible = true;
            label4.Visible = true;
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id;
            if (dataGrid.Columns[e.ColumnIndex].Name == "Sua")
            {
                if (index_row == 0)
                {
                    MessageBox.Show("Dữ liệu trống không thể sửa!");
                    return;
                }
                hide_button_add();
                show_button_luu();
                MessageBox.Show("Nhập lại nội dung muốn sửa");
                id = dataGrid.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
                foreach(var item in listCtTH)
                {
                    if(item.MaNS.ToString()==id)
                    {
                        comboBoxTenCay.Text = dNS.SingleOrDefault(tem => tem.Key.ToString() == id).Value;
                        textSanLuongThuHoach.Text = item.SanLuongThuHoach.ToString();
                        textSanLuongThietHai.Text = item.SanLuongThietHai.ToString();
                    }
                }
                comboBoxTenCay.Enabled = false;
            }
            QLNTEntities1 db = new QLNTEntities1();

            if (dataGrid.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if(index_row==0)
                {
                    MessageBox.Show("Dữ liệu trống không thể xóa!");
                    return;
                }
                id = dataGrid.Rows[e.RowIndex].Cells["MaNS"].Value.ToString();
                var re = listCtTH.Where(p => p.MaNS == Convert.ToInt32(id)).SingleOrDefault();
                listCtTH.Remove(re);
                index_row--;
                var tencay = dNS.Where(p => p.Key == Convert.ToInt32(id)).SingleOrDefault().Value;
                comboBoxTenCay.Items.Add(tencay);
                var result = from c in listCtTH
                         join ns in db.NongSan on c.MaNS equals ns.MaNS
                         join p in db.Cay on ns.MaLoaiCay equals p.MaLoaiCay
                         where c.MaNS != Convert.ToInt32(id)
                             select new { MaNS = c.MaNS, TenCay = p.TenCay, SanLuongThuHoach = c.SanLuongThuHoach, SanLuongThietHai = c.SanLuongThietHai };
                
                dataGrid.DataSource = result.ToList();  
            }
        }

       
    }
}
