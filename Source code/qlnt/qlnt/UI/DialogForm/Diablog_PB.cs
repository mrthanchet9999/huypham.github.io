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
 
    public partial class Diablog_PB : Form
    {

        PhanBonBUS bus = new PhanBonBUS();
        PhanBon o;
        int id;

        public Diablog_PB()
        {
            InitializeComponent();
            border();
            List<string> l = new List<string>() { "Vô cơ", "Hữu cơ" };
            comboBoxLoai.DataSource = l;
        }
        public Diablog_PB(string id)
        {
            InitializeComponent();
            border();
            PhanBonDB db = new PhanBonDB();
            List<string> l = new List<string>() { "Vô cơ", "Hữu cơ" };
            comboBoxLoai.DataSource = l;
            // load noi dung de sua thong tin
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.getPhanBon(id);
            textTenPB.Text = o.TenPB ;
            comboBoxLoai.Text = o.Loai;
            textDonGia.Text = o.DonGia.ToString();
            textKhoiLuong.Text = o.KhoiLuong.ToString();
            textSoLuong.Text = o.SoLuong.ToString();
            DatepickerSX.Value = o.NgaySX;
            DatepickerSX.Value.ToString("dd/MM/yyyy");
            DatepickerHSD.Value = o.HanSD;
            DatepickerHSD.Value.ToString("dd/MM/yyyy");
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
            if (c.isNUll(textTenPB.Text))
            {
                MessageBox.Show("Dữ liệu tên phân bón không được để rỗng");
                textTenPB.Focus();
                return false;
            }
            if (c.isNUll(comboBoxLoai.Text))
            {
                MessageBox.Show("Dữ liệu loại không được để rỗng");
                comboBoxLoai.Focus();
                return false;
            }
            if (c.isNUll(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSoLuong.Focus();
                return false;
            }
            if (c.isNUll(textKhoiLuong.Text))
            {
                MessageBox.Show("Dữ liệu khối lượng không được để rỗng");
                textKhoiLuong.Focus();
                return false;
            }
            if (!c.isNumber(textDonGia.Text))
            {
                MessageBox.Show("Dữ liệu đơn giá phải là số");
                textDonGia.Focus();
                return false;
            }
            if (!c.isNumber(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSoLuong.Focus();
                return false;
            }
            if (!c.isNumber(textKhoiLuong.Text))
            {
                MessageBox.Show("Dữ liệu khối lượng phải là số");
                textKhoiLuong.Focus();
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
                o = new PhanBon() { TenPB = textTenPB.Text, Loai = comboBoxLoai.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), DonGia = Convert.ToDouble(textDonGia.Text), KhoiLuong = Convert.ToInt32(textKhoiLuong.Text), NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date };
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
            List<string> l=new List<string>() {"Vô cơ", "Hữu cơ"} ;
            comboBoxLoai.DataSource = l;
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
      
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (check())
            {
                o = new PhanBon() { MaPB = this.id, TenPB = textTenPB.Text, Loai = comboBoxLoai.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), DonGia = Convert.ToDouble(textDonGia.Text), KhoiLuong = Convert.ToInt32(textKhoiLuong.Text), NgaySX = DatepickerSX.Value.Date, HanSD = DatepickerHSD.Value.Date };
                bus.Edit(o);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }

        private void Diablog_PB_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
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
