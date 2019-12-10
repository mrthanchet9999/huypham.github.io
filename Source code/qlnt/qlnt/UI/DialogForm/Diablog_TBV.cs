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
 
    public partial class Diablog_TBV : Form
    {
        ThuocBaoVeTVBUS bus = new ThuocBaoVeTVBUS();
        ThuocBaoVeTV o;
        int id;

        public Diablog_TBV()
        {
            InitializeComponent();
            border();
            List<string> l = new List<string>() { "Dung dịch", "Hạt", "Bột", "Viên", "Nhũ dầu", "Huyền phù", "Thuốc phun bột" };
            comboboxDang.DataSource = l;
            Dictionary<string, string> d;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d = (
                    from c in db.DoDoc
                    select new { c.MaDoc, c.MucDoDoc }

                    ).ToDictionary(c => c.MaDoc, c => c.MucDoDoc);
            }
            comboboxDoDoc.DataSource = d.Values.ToList();
        }
        public Diablog_TBV(string id)
        {
            InitializeComponent();
            border();
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            List<string> l = new List<string>() { "Dung dịch", "Hạt", "Bột", "Viên", "Nhũ dầu", "Huyền phù", "Thuốc phun bột" };
            comboboxDang.DataSource = l;
            Dictionary<string, string> dic;
            using (QLNTEntities1 db1 = new QLNTEntities1())
            {
                dic = (
                    from c in db1.DoDoc
                    select new { c.MaDoc, c.MucDoDoc }

                    ).ToDictionary(c => c.MaDoc, c => c.MucDoDoc);
            }
            comboboxDoDoc.DataSource = dic.Values.ToList();
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.GetThuocBaoVeTV(id);
            textTenThuoc.Text = o.TenThuoc ;
            textThoiGianCachLy.Text = o.ThoiGianCachLy.ToString();
            textNoiSX.Text = o.NoiSX;
            comboboxDang.Text = o.Dang;
            textSoLuong.Text = o.SoLuong.ToString();
            textCongDung.Text = o.CongDung;
            DatepickerSX.Value = o.NgaySX;
            DatepickerSX.Value.ToString("dd/MM/yyyy");
            DatepickerHSD.Value = o.HanSD;
            DatepickerHSD.Value.ToString("dd/MM/yyyy");
            var temp = o.MaDoc;
            Dictionary<string, string> d;
            using (QLNTEntities1 db1 = new QLNTEntities1())
            {
                d = (
                    from z in db1.DoDoc
                    select new { z.MaDoc, z.MucDoDoc }

                    ).ToDictionary(z => z.MaDoc, z => z.MucDoDoc);
            }
            var kq = d.Values.ToString();
            foreach (var k in d)
            {
                if (k.Key.ToString() == temp.ToString())
                {

                    kq = k.Value.ToString();
                    break;
                }
            }
            comboboxDoDoc.Text = kq;
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
            if (c.isNUll(textTenThuoc.Text))
            {
                MessageBox.Show("Dữ liệu tên thuốc không được để rỗng");
                textTenThuoc.Focus();
                return false;
            }
            if (c.isNUll(comboboxDang.Text))
            {
                MessageBox.Show("Dữ liệu dạng thuốc không được để rỗng");
                comboboxDang.Focus();
                return false;
            }
            if (!c.isNumber(textThoiGianCachLy.Text))
            {
                MessageBox.Show("Dữ liệu phải là số");
                textThoiGianCachLy.Focus();
                return false;
            }
            if (c.isNUll(textNoiSX.Text))
            {
                MessageBox.Show("Dữ liệu nơi sản xuất không được để rỗng");
                textNoiSX.Focus();
                return false;
            }
            if (!c.isNumber(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSoLuong.Focus();
                return false;
            }
            if (c.isNUll(textCongDung.Text))
            {
                MessageBox.Show("Dữ liệu công dụng không được để trống");
                textCongDung.Focus();
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

            if(check())
            {
                var temp = comboboxDoDoc.Text;
                Dictionary<string, string> d;
                using (QLNTEntities1 db = new QLNTEntities1())
                {
                    d = (
                        from z in db.DoDoc
                        select new { z.MaDoc, z.MucDoDoc }

                        ).ToDictionary(z => z.MaDoc, z => z.MucDoDoc);
                }
                var kq = d.Keys.ToString();
                foreach (var k in d)
                {
                    if (k.Value.ToString() == temp.ToString())
                    {
                        
                        kq = k.Key.ToString();
                        break;
                    }
                }
                o = new ThuocBaoVeTV() { TenThuoc = textTenThuoc.Text, Dang = comboboxDang.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), ThoiGianCachLy = Convert.ToInt32(textThoiGianCachLy.Text),NoiSX=textNoiSX.Text,CongDung=textCongDung.Text,NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date,MaDoc=kq };
                bus.Add(o);
                MessageBox.Show("Thêm thành công");
                Dialog_close();
            }            
            #region kt
            //string t="Tên phân bón : {0} \n Loại: {1} \n Ngày sx: {2} \n hạn sử dụng: {3}";
            //string msg = string.Format(t,o.TenPB,o.Loai,o.NgaySX.ToString("dd//MM/yyyy"), o.HanSD.ToString("dd//MM/yyyy"));
            //MessageBox.Show(msg);

            //DatepickerSX.Value.ToString("dd/MM/yyyy")
            //MessageBox.Show(textTenPB.Text+" " + comboBoxLoai.Text );

            //MessageBox.Show("thành công");
            #endregion

        }

        /*private void add_PB_Load(object sender, EventArgs e)
        {
            List<string> l=new List<string>() {"Dung dịch","Hạt","Bột","Viên","Nhũ dầu","Huyền phù","Thuốc phun bột"} ;
            comboboxDang.DataSource = l;
            //DatepickerSX.Format = DateTimePickerFormat.Custom;
            //DatepickerSX.FormatCustom = "dd/MM/yyyy";();
            Dictionary<string, string> d;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d = (
                    from c in db.DoDoc
                    select new { c.MaDoc, c.MucDoDoc }

                    ).ToDictionary(c => c.MaDoc, c => c.MucDoDoc);
            }
            comboboxDoDoc.DataSource = d.Values.ToList();
        }*/

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (check())
            {
                var temp = comboboxDoDoc.Text;
                Dictionary<string, string> d;
                using (QLNTEntities1 db = new QLNTEntities1())
                {
                    d = (
                        from z in db.DoDoc
                        select new { z.MaDoc, z.MucDoDoc }

                        ).ToDictionary(z => z.MaDoc, z => z.MucDoDoc);
                }
                var kq = d.Keys.ToString();
                foreach (var k in d)
                {
                    if (k.Value.ToString() == temp.ToString())
                    {

                        kq = k.Key.ToString();
                        break;
                    }
                }
                o = new ThuocBaoVeTV() { MaThuoc = this.id, TenThuoc = textTenThuoc.Text, Dang = comboboxDang.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), ThoiGianCachLy = Convert.ToInt32(textThoiGianCachLy.Text), NoiSX = textNoiSX.Text, CongDung = textCongDung.Text, NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date,MaDoc=kq};
                bus.Edit(o);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }

        private void Diablog_TBV_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
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
    }
}
