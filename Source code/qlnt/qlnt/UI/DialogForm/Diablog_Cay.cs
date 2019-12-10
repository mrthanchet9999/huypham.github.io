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
using qlnt.UI.DialogForm;

namespace qlnt.UI
{
  
    public partial class Diablog_Cay : Form,InterfaceDialog
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
        CayBUS bus = new CayBUS();
        Cay o;
        int id;

        public Diablog_Cay()
        {
            InitializeComponent();
            border();
            List<string> l = new List<string>() { "Xuân", "Hạ", "Thu", "Đông" };
            comboBoxMuaThuHoach.DataSource = l;
        }
        public Diablog_Cay(string id)
        {
            InitializeComponent();
            border();
            CayDB db = new CayDB();
            // load noi dung de sua thong tin
            List<string> l = new List<string>() { "Xuân", "Hạ", "Thu", "Đông" };
            comboBoxMuaThuHoach.DataSource = l;
            #region gắn giá trị
            this.id = Convert.ToInt32(id);
            o = db.GetCay(id);
            textTenCay.Text = o.TenCay ;
            comboBoxMuaThuHoach.Text = o.MuaThuHoach;
            textSoLuong.Text = o.SoLuong.ToString();
            DatepickerNamTrongCay.Value = o.NamTrongCay ;
            DatepickerNamTrongCay.Value.ToString("dd/MM/yyyy");
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
            if (c.isNUll(textTenCay.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textTenCay.Focus();
                return false;
            }
            if (c.isNUll(comboBoxMuaThuHoach.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                comboBoxMuaThuHoach.Focus();
                return false;
            }
            if (c.isNUll(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu không được để rỗng");
                textSoLuong.Focus();
                return false;
            }
            if (!c.isNumber(textSoLuong.Text))
            {
                MessageBox.Show("Dữ liệu số lượng phải là số");
                textSoLuong.Focus();
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
                o = new Cay() {TenCay = textTenCay.Text, SoLuong = Convert.ToInt32(textSoLuong.Text), MuaThuHoach = comboBoxMuaThuHoach.Text, NamTrongCay =DatepickerNamTrongCay.Value.Date };
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

            
            #endregion

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
      
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            if (check())
            {
                o = new Cay() { MaLoaiCay = this.id, TenCay = textTenCay.Text, MuaThuHoach = comboBoxMuaThuHoach.Text, SoLuong = Convert.ToInt32(textSoLuong.Text),NamTrongCay=DatepickerNamTrongCay.Value.Date, };
                bus.Edit(o);
                MessageBox.Show("Sửa thành công");
                Dialog_close();
            }
        }

        private void labelTen_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Diablog_Cay_Load(object sender, EventArgs e)
        {

        }
    }
}
