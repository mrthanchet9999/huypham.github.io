using qlnt.BUS;
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

namespace qlnt.UI
{
    public partial class FormQuanLyKho : Form
    {
        // danh sach hàng trong kho
        List<HangHoa> list = new List<HangHoa>();
        List<HangHoa> listHuy = new List<HangHoa>();
        public FormQuanLyKho()
        {
            InitializeComponent();
        }
        
        
        public void loadHuy()
        {
            for (int i = 0; i < list.Count; i++)
            {
                var row = dataGrid.Rows[i].Cells["TinhTrang"];
                string s = row.Value.ToString();
                if (s.Equals("Hết hạn sử dụng"))
                {
                    listHuy.Add(list.ElementAt(i));
                }
            }
            if(listHuy.Count==0)
            {
                btnThongBao.Visible = false;
            }
            comboBoxLoai.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLoai.Text = "Tất cả";
            comboBoxTT.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTT.Text = "Tất cả";

        }
        public void load()
        {
            ///load sanh sach hàng hóa trong kho
            PhanBonBUS busPB = new PhanBonBUS();
            ThuocBaoVeTVBUS busTBV = new ThuocBaoVeTVBUS();
            NongSanBUS busNS = new NongSanBUS();
            list.Clear();
            list.AddRange(busPB.getListPhanBon());
            list.AddRange(busTBV.getListTBV());
            list.AddRange(busNS.getListNongSan());

            ////////

            dataGrid.DataSource = list;
            for (int i = 0; i < list.Count; i++)
            {
                var row = dataGrid.Rows[i].Cells["TinhTrang"];
                string s = row.Value.ToString();
                if (s.Equals("Hết hạn sử dụng"))
                {
                    row.Style.ForeColor = Color.Red;
                }
            }
        }
        private void FormQuanLyKho_Load(object sender, EventArgs e)
        {
            load();
            dataGrid.Columns["ma"].Visible = false;
            loadHuy();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            
            dataGrid.DataSource = listHuy;
            for (int i = 0; i < listHuy.Count; i++)
            {
                var row = dataGrid.Rows[i].Cells["TinhTrang"];
                string s = row.Value.ToString();
                if (s.Equals("Hết hạn sử dụng"))
                {
                    row.Style.ForeColor = Color.Red;
                }
            }
            if(listHuy.Count>0)
            {
                btnHuy.Visible = true;
            }
            //listHuy.Clear();
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            load();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn hủy","Hủy hàng quá hạn",MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
            {
                PhanBonBUS busPB = new PhanBonBUS();
                ThuocBaoVeTVBUS busTBV = new ThuocBaoVeTVBUS();
                NongSanBUS busNS = new NongSanBUS();
                busPB.setHuySL(listHuy);
                busTBV.setHuySL(listHuy);
                busNS.setHuySL(listHuy);
                load();
                btnThongBao.Visible = false;
                btnHuy.Visible = false;
            }
        }

        private void bunifuCustomTextbox1_KeyUp(object sender, KeyEventArgs e)
        {

            HangHoa h = new HangHoa();
            List<string> l = h.getListSearchName(list, textTen.Text);
            listBoxSearch.DataSource = l;
            checkString c = new checkString();

            if (c.isNUll(textTen.Text))// textbox chưa nhập liệu
            {
                listBoxSearch.Visible = false;
            }
            else
                if (l.Count != 0)// tìm thấy tên 
            {
                listBoxSearch.Visible = true;
            }
            else // không tìm thấy tên
                listBoxSearch.Visible = false;
            if (e.KeyCode == Keys.Enter)
            {
                textTen.Text = listBoxSearch.SelectedItem.ToString();
                loadSearch(textTen.Text);
             
            }

        }

        private void listBoxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            textTen.Text = listBoxSearch.SelectedItem.ToString();
            listBoxSearch.Visible = false;
        }

        private void textTen_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        public void loadSearch(string name)
        {
            HangHoa busHH = new HangHoa();
            List<HangHoa> l = new List<HangHoa>();
            l.AddRange(list);
            if(l.Count ==0)
            {
                MessageBox.Show("Không tìm thấy");
                load();
            }
            dataGrid.DataSource= busHH.getListSearch(l,name);
            listBoxSearch.Visible = false;
            

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            loadSearch(textTen.Text);
        }
        #region lọc tình trang và loại
        public void searchTinhTrang(string tinhTrang)
        {
            List<HangHoa> l = new List<HangHoa>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).tinhTrang.Equals(tinhTrang))
                {
                    l.Add(list.ElementAt(i));
                }
            }
            if(l.Count==0)
            {
                MessageBox.Show("Không tìm thấy");
                load();
                return;
            }
            dataGrid.DataSource = l;
        }
        public void searchLoai(string loai)
        {
            List<HangHoa> l = new List<HangHoa>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).loai.Equals(loai))
                {
                    l.Add(list.ElementAt(i));
                }
            }
            if (l.Count == 0)
            {
                MessageBox.Show("Không tìm thấy");
                load();
                return;
            }
            dataGrid.DataSource = l;
        }
        public void searchTinhTrang_Loai(string tinhTrang ,string loai)
        {
            List<HangHoa> l = new List<HangHoa>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list.ElementAt(i).tinhTrang.Equals(tinhTrang) && list.ElementAt(i).loai.Equals(loai))
                {
                    l.Add(list.ElementAt(i));
                }
            }
            if (l.Count == 0)
            {
                MessageBox.Show("Không tìm thấy");
                load();
                return;
            }
            dataGrid.DataSource = l;
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnHuy.Visible = false;
            if (comboBoxLoai.Text.Equals("Tất cả") && comboBoxTT.Text.Equals("Tất cả") )
            {
                load();
            }
            else
            {
                
                if (comboBoxLoai.Text.Equals("Tất cả"))
                    searchTinhTrang(comboBoxTT.Text);
                else
                    if (comboBoxTT.Text.Equals("Tất cả"))
                        searchLoai(comboBoxLoai.Text);
                    else
                        searchTinhTrang_Loai(comboBoxTT.Text, comboBoxLoai.Text);
            }

        }
    }
}

