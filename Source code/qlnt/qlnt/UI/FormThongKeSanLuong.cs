using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using qlnt.DB.Entity;
using qlnt.BUS;

namespace qlnt.UI
{
    public partial class FormThongKeSanLuong : Form
    {
        
        public FormThongKeSanLuong()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            comboThang.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNam.DropDownStyle = ComboBoxStyle.DropDownList;
            List<int> l = new List<int>();
            for(int i=2015;i<=DateTime.Now.Year;i++)
            {
                l.Add(i);
            }
            comboBoxNam.DataSource = l;
            comboBoxNam.Text = DateTime.Now.Year.ToString();
            comboThang.Text = DateTime.Now.Month.ToString();
            loadChart();
        }
        
        private void loadChart()
        {   
            QLNTEntities1 db = new QLNTEntities1();
            var result = db.ThongKeSanLuong(Convert.ToInt16(comboThang.Text), Convert.ToInt32(comboBoxNam.Text));
            int i = 0;

            //chart2.Series["SLThuHoach"].IsValueShownAsLabel = false;
            chart2.Series["SLThuHoach"].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.Title = "Nông sản";
            chart1.ChartAreas[0].AxisY.Title = "Kg";
            foreach (var item in result)
            {
                ///Bar chart 
                chart1.Series["SLThuHoach"].Points.AddXY(item.TenNS, item.SLThuHoach);
                chart1.Series["SLThietHai"].Points.AddXY(item.TenNS, item.SLThietHai);
                chart1.Series["SLThuHoach"].Points[i].Label = item.SLThuHoach.ToString();
                chart1.Series["SLThietHai"].Points[i].Label = item.SLThietHai.ToString();


                //Pie chart
                chart2.Series["SLThuHoach"].Points.AddXY(item.TenNS, item.SLThuHoach);
                i++;
            }
            if(i==0)
            {
                MessageBox.Show(string.Format("Không có dữ liệu tháng {0} năm {1}",comboThang.Text,comboBoxNam.Text));
                chart1.Visible = false;
                chart2.Visible = false;
            }
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            chart2.Visible = true;
            loadChart();
        }
    }
}

