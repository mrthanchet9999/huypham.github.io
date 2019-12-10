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
  
    public partial class Diablog_viewbangth : Form
    {
        BangThuHoachBUS bus = new BangThuHoachBUS();
        public Diablog_viewbangth(string id)
        {
            InitializeComponent();
            border();
            int ma = Convert.ToInt32(id);
            QLNTEntities1 db = new QLNTEntities1();
            string la = db.BangThuHoach.Where(c => c.MaBang == ma).SingleOrDefault().NgayThuHoach.ToString() ;
            label3.Text = la;
            var result = from c in db.ChiTiet_TH
                         join ns in db.NongSan on c.MaNS equals ns.MaNS
                         join p in db.Cay on ns.MaLoaiCay equals p.MaLoaiCay
                         where c.MaBang == ma
                         select new {TenCay = p.TenCay, SanLuongThuHoach = c.SanLuongThuHoach, SanLuongThietHai = c.SanLuongThietHai,MaBang=c.MaBang };
            dataGrid.DataSource = result.ToList();
            //button_luu.Enabled = false;
        }
        /*public bool check()
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
            DatepickerNgayThuHoach.Value = DateTime.Now;
        }
        List<ChiTiet_TH> listCtTH = new List<ChiTiet_TH>();

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

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

        /*private void bunifuImageButton2_Click(object sender, EventArgs e)
{
       //List<NongSan> listNS = new List<NongSan>();
       QLNTEntities1 db = new QLNTEntities1();
       ChiTiet_TH temp = new ChiTiet_TH();
       int maNS = dNS.FirstOrDefault(c => c.Value == comboBoxTenCay.Text).Key;
       temp.MaNS = maNS;
       temp.SanLuongThuHoach = Convert.ToDouble(textSanLuongThuHoach.Text);
       temp.SanLuongThietHai = Convert.ToDouble(textSanLuongThietHai.Text);


       listCtTH.Add(temp);
       var result = from c in listCtTH join ns in db.NongSan on c.MaNS equals ns.MaNS join p in db.Cay on ns.MaLoaiCay equals p.MaLoaiCay
                    select new { MaNS=c.MaNS,TenCay= p.TenCay,SanLuongThuHoach=c.SanLuongThuHoach, SanLuongThietHai=c.SanLuongThietHai} ;
       dataGrid.DataSource = result.ToList();
   }
}
private void bunifuFlatButton1_Click(object sender, EventArgs e)
{

   /// Thêm bảng thu hoạch trả về id vừa thêm
  // int id =???;
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
       MessageBox.Show(id.ToString());
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


}*/
    }
}
