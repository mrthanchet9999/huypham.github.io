using qlnt.BUS;
using qlnt.DB;
using qlnt.DB.Entity;
using System;
using System.Collections;
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
    public partial class Dialog_LapKeHoach : Form
    {
        List<CheckBox> listCheck = new List<CheckBox>();
        Dictionary<int, string> loai = new Dictionary<int, string>();
        KeHoachBUS bus = new KeHoachBUS();
        public Dialog_LapKeHoach()
        {
            InitializeComponent();
            border();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoaiKHBUS bus1 = new LoaiKHBUS();
            loai = bus1.View();
            DatepickerThucHien.Value = DateTime.Now.AddDays(1);
            int kc = 10;
            int i = 0;
            foreach(var item in loai)
            {
             
                CheckBox temp = new CheckBox();
                temp.Text = item.Value;
                temp.Location = new Point(kc, 10);
                
                //MessageBox.Show(temp.Size.ToString());
                listCheck.Add(temp);
                panelRadio.Controls.Add(temp);
                kc += 120;
                i++;
            }
            
            Controls.Add(panelRadio);
            //MessageBox.Show(l.Count.ToString());

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool check()
        {
            checkString c = new checkString();

            int compare = DateTime.Compare(DatepickerThucHien.Value.Date,DateTime.Now);
            if(compare < 0)
            {
                MessageBox.Show("Thời gian thực hiện trước thời gian hiện tại");
                return false;
            }
            if(c.isNUll(richTextBoxND.Text))
            {
                MessageBox.Show("Nội dung thực hiện không được để trống");
                return false;
            }
            
            return true;
        }

        


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // kiểm tra nội dung vừa nhập
            if (check() == false)
                return;
            //danh sách chứa check box được chọn
            List<int> l = new List<int>();

            foreach(CheckBox item in listCheck)
            {
                if(item.Checked==true)
                {
                    int key = loai.FirstOrDefault(x=>x.Value==item.Text).Key;
                    l.Add(key);
                }
            }
            //MessageBox.Show(l.Count.ToString());
            // kiểm tra đã chọn công việc chưa
            if (l.Count != 0)
            {
                KeHoach o = new KeHoach();
                o.NgayThucHien = DatepickerThucHien.Value.Date;
                o.NoiDung = richTextBoxND.Text;
                o.ChuThich = richTextBoxCT.Text;
                o.SoLuongCongViec = l.Count;
                o.SoLuongCongViecHoanThanh = 0;
                //// set lại đăng nhập
                o.MaNguoiLap = 1;

                bus.Add(o,l);
                MessageBox.Show("Đã lập thành công");
                Close();
                
                
                
            }
           


            
        }

        


        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //truyền tên cây tìm được vào textbox
        

       

        //cấu hình panel hiện số lượng
        private void checkBoxSL_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        // ẩn hiện panel số lượng
        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}

