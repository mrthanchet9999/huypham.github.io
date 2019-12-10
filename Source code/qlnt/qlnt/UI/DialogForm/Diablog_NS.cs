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
using System.Text.RegularExpressions;
using qlnt.BUS;
using qlnt.DB.Entity;

namespace qlnt.UI
{

    public partial class Diablog_NS : Form
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
        NongSanBUS bus = new NongSanBUS();
        CayBUS busCay = new CayBUS();
        Dictionary<int, string> ds = new Dictionary<int, string>();
        NongSan o;
        //Cay c;
        int id;

        public Diablog_NS()
        {
            InitializeComponent();
            border();
            ds = busCay.getAllNameTree();
            comboBoxLoaiCay.DataSource = ds.Values.ToList();
        }
        public Diablog_NS(string id)
        {
            InitializeComponent();
            border();
            NongSanDB db = new NongSanDB();
            ds = busCay.getAllNameTree();
            // MessageBox.Show(ds.Count.ToString());
            comboBoxLoaiCay.DataSource = ds.Values.ToList();
            // load noi dung de sua thong tin
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.getNongSan(id);
            textThoiGianBaoQuan.Text = o.ThoiGianBaoQuan.ToString();
            textSanLuongTonKho.Text = o.SanLuongTonKho.ToString();
            textDonGia.Text = o.DonGia.ToString();
            Dictionary<int, string> d;
            using (QLNTEntities1 db1= new QLNTEntities1())
            {
                d = (
                    from z in db1.Cay
                    select new { z.MaLoaiCay, z.TenCay }

                    ).ToDictionary(z => z.MaLoaiCay, z => z.TenCay);
            }
            var kq = d.Values.ToString();
            foreach (var k in d)
            {
                if (k.Key.ToString() == o.MaLoaiCay.ToString())
                {
                    kq = k.Value.ToString();
                    break;
                }
            }
            comboBoxLoaiCay.Text = kq;
            #endregion
            // An button add
            button_add.Enabled = false;
            button_add.Visible = false;
            //Hien button luu
            button_luu.Visible = true;
            //button_luu.Enabled = false;
        }
        public bool check()
        {
            checkString c = new checkString();
            if (c.isNUll(textThoiGianBaoQuan.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textThoiGianBaoQuan.Focus();
                return false;
            }
            if (c.isNUll(textSanLuongTonKho.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textSanLuongTonKho.Focus();
                return false;
            }
            if (c.isNUll(textDonGia.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textDonGia.Focus();
                return false;
            }
            return true;
        }
        private void Dialog_close()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button_add_Click(object sender, EventArgs e)
        {

            if (check())
            {
                var temp = comboBoxLoaiCay.Text;
                Dictionary<int, string> d;
                using (QLNTEntities1 db = new QLNTEntities1())
                {
                    d = (
                        from z in db.Cay
                        select new { z.MaLoaiCay, z.TenCay }

                        ).ToDictionary(z => z.MaLoaiCay, z => z.TenCay);
                }
                var key = d.Values;
                var kq = d.Keys.ToString();
                foreach (var k in d)
                {
                    if (k.Value.ToString()==temp.ToString())
                    {
                        kq = k.Key.ToString();
                        break;
                    }
                }
                o = new NongSan() { ThoiGianBaoQuan = Convert.ToInt32(textThoiGianBaoQuan.Text), SanLuongTonKho = Convert.ToDouble(textSanLuongTonKho.Text), DonGia = Convert.ToDouble(textDonGia.Text),MaLoaiCay=Convert.ToInt32(kq) };
                bus.Add(o);
                MessageBox.Show("Thêm thành công");
                Dialog_close();
                //}
                
                #region kt
                //string t="Tên phân bón : {0} \n Loại: {1} \n Ngày sx: {2} \n hạn sử dụng: {3}";
                //string msg = string.Format(t,o.TenPB,o.Loai,o.NgaySX.ToString("dd//MM/yyyy"), o.HanSD.ToString("dd//MM/yyyy"));
                //MessageBox.Show(msg);

                //DatepickerSX.Value.ToString("dd/MM/yyyy")
                //MessageBox.Show(textTenPB.Text+" " + comboBoxLoai.Text );

                //MessageBox.Show("thành công");
                #endregion

            }

            /*private void bunifuFlatButton1_Click(object sender, EventArgs e)
            {

                if (check())
                {
                    o = new NongSan() { MaNS = this.id, ThoiGianBaoQuan = Convert.ToInt32(textThoiGianBaoQuan.Text), SanLuongTonKho = Convert.ToDouble(textSanLuongTonKho), DonGia = Convert.ToDouble(textDonGia.Text), BaoQuan = textBaoQuan.Text };
                    bus.Edit(o);
                    
                    Dialog_close();
                }
            }

            private void Diablog_NS_Load(object sender, EventArgs e)
            {
                ds = busCay.getAllNameTree();
                // MessageBox.Show(ds.Count.ToString());
                comboBoxLoaiCay.DataSource = ds.Values.ToList();
            }*/
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Diablog_NS_Load(object sender, EventArgs e)
        {
            ds = busCay.getAllNameTree();
            // MessageBox.Show(ds.Count.ToString());
            comboBoxLoaiCay.DataSource = ds.Values.ToList();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (check())
            {
                var temp = comboBoxLoaiCay.Text;
                /*var re = from c in db.NongSan
                         join d in db.Cay on c.MaLoaiCay equals d.MaLoaiCay
                         where String.Compare(temp, d.TenCay.ToString(), true);
                         select new ()*/
                Dictionary<int, string> d;
                using (QLNTEntities1 db = new QLNTEntities1())
                {
                    d = (
                        from z in db.Cay
                        select new { z.MaLoaiCay, z.TenCay }

                        ).ToDictionary(z => z.MaLoaiCay, z => z.TenCay);
                }
                
                var key = d.Values;
                var kq = d.Keys.ToString();
                foreach (var k in d)
                {
                    if (k.Value.ToString() == temp.ToString())
                    {
                        kq = k.Key.ToString();
                        break;
                    }
                }
                //MessageBox.Show(kq);
                o = new NongSan() {MaNS=this.id, ThoiGianBaoQuan = Convert.ToInt32(textThoiGianBaoQuan.Text), SanLuongTonKho = Convert.ToDouble(textSanLuongTonKho.Text), DonGia = Convert.ToDouble(textDonGia.Text), MaLoaiCay = Convert.ToInt32(kq) };
                bus.Edit(o);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }

        private void Diablog_NS_Load_1(object sender, EventArgs e)
        {

        }
    }
}
