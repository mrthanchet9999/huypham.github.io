using qlnt.BUS;
using qlnt.DB;
using qlnt.DB.Entity;
using qlnt.UI.DialogForm;
using System;
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
    public partial class Dialog_XemCTKH : Form,InterfaceDialog
    {
        KeHoachBUS bus = new KeHoachBUS();
        KeHoach k = new KeHoach();
        public Dialog_XemCTKH()
        {
            InitializeComponent();
        }

        public void View(string id)
        {
            bus.getCTKeHoach(id, dataGrid);
            try
            {
                dataGrid.Rows[0].Selected = false;
            }
            catch { }
        }
        public void load(string id)
        {
            checkString c = new checkString();
            k = bus.getKeHoach(id);
            View(id);
            labelXemThoiGian.Text = k.NgayThucHien.ToString("dd/MM/yyyy");
            richTextBoxND.Text = k.NoiDung;
            richTextBoxCT.Text = k.ChuThich;
        }
        public Dialog_XemCTKH(string id)
        {
            
            InitializeComponent();
            load(id);

        }

        private void FormChiTietKeHoach_Load(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maLoai;
            if (dataGrid.Columns[e.ColumnIndex].Name == "HoanThanh")
            {
                maLoai = dataGrid.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString();
                bool v= Convert.ToBoolean(dataGrid.Rows[e.RowIndex].Cells["HoanThanh"].Value.ToString()) ;
                
                ChiTietKH c = new ChiTietKH();
                c.MaKH = k.MaKeHoach;
                c.MaLoai = Convert.ToInt32(maLoai);
                if (v == true)
                    bus.setHoanHanh(c, false);
                else
                    bus.setHoanHanh(c, true);
                View(k.MaKeHoach.ToString());
            }
            if (dataGrid.Columns[e.ColumnIndex].Name == "Xoa")
            {
                ///không cho xóa
                if(dataGrid.RowCount==1)
                {
                    MessageBox.Show("Ít nhất phải có 1 công việc","Không được xóa");
                }
                else
                {
                    maLoai = dataGrid.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString();
                    bus.DeleteCtKH(k.MaKeHoach, Convert.ToInt32(maLoai));
                    View(k.MaKeHoach.ToString());
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        void setStateRichText(RichTextBox r,bool readOnly,Color c)
        {
            r.ReadOnly = readOnly;
            r.BackColor = c;
            r.Focus();
        }
        private void Save()
        {
            if (MessageBox.Show("Bạn có muốn lưu", "Lưu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bus.Edit(k.MaKeHoach, richTextBoxND.Text, richTextBoxCT.Text);
                MessageBox.Show("Lưu thành công");
            }
            
        }
        private void editND_Click(object sender, EventArgs e)
        {
            setStateRichText(richTextBoxND, false, Color.White);
            panelSaveND.Visible = true;
            btnEditND.Visible=false;
        }

        private void saveND_Click(object sender, EventArgs e)
        {
            checkString c = new checkString();
            if(c.isNUll(richTextBoxND.Text))
            {
                MessageBox.Show("Nội dung không được để trống");
                return;
            }
            Save();
            load(k.MaKeHoach.ToString());
            setStateRichText(richTextBoxND, true, Color.FromArgb(227, 227, 227));
            panelSaveND.Visible = false;
            btnEditND.Visible = true;
        }

        private void editCT_Click(object sender, EventArgs e)
        {
            setStateRichText(richTextBoxCT, false, Color.White);
            panelSaveCT.Visible = true;
            btnEditCT.Visible = false;
            
        }

        private void saveCT_Click(object sender, EventArgs e)
        {
            Save();
            setStateRichText(richTextBoxCT, true, Color.FromArgb(227, 227, 227));
            load(k.MaKeHoach.ToString());
            panelSaveCT.Visible = false;
            btnEditCT.Visible = true;
        }

        private void notSaveND_Click(object sender, EventArgs e)
        {
            setStateRichText(richTextBoxND, true, Color.FromArgb(227, 227, 227));
            load(k.MaKeHoach.ToString());
            panelSaveND.Visible = false;
            btnEditND.Visible = true;
        }

        

        private void notSaveCT_Click(object sender, EventArgs e)
        {
            setStateRichText(richTextBoxCT, true, Color.FromArgb(227, 227, 227));
            load(k.MaKeHoach.ToString());
            panelSaveCT.Visible = false;
            btnEditCT.Visible = true;
        }
        //Mở dialog thêm công việc chưa có
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dialog_AddCTKH d = new Dialog_AddCTKH(k.MaKeHoach);
            d.ShowDialog(this);
            View(k.MaKeHoach.ToString());
            
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
