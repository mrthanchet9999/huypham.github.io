using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using qlnt.DB.Entity;
using qlnt.BUS;

namespace qlnt.UI
{
    public partial class FormThongKeDoanhThuTheoNam : Form
    {
        public FormThongKeDoanhThuTheoNam()
        {
            InitializeComponent();
        }
        
        private void ThongKeDoanhThuTheoNam_Load(object sender, EventArgs e)
        {
            createListYear();
            //chart1.Titles[0].Text = "Biểu đồ doanh thu năm "+comboBoxNam.Text;
        }
        private void loadChart() 
        {
            QLNTEntities1 db = new QLNTEntities1();
            var result = db.ThongKeDoanhThuTheoNam(Convert.ToInt32(comboBoxNam.Text));
            var chart = chart1.ChartAreas[0];
            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisX.Title = "Tháng";
            chart.AxisY.Title = "Triệu";
            foreach (var item in result)
            {
                chart1.Series["DoanhThu"].Points.AddXY(item.Thang, (item.DoanhThu * 1.0) / 1000000);
                
            }
        }
        public void createListYear()
        {
            comboBoxNam.DropDownStyle = ComboBoxStyle.DropDownList;
            List<int> l = new List<int>();
            for (int i = 2015; i <= DateTime.Now.Year; i++)
            {
                l.Add(i);
            }
            comboBoxNam.DataSource = l;
            comboBoxNam.Text = DateTime.Now.Year.ToString();
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            chart1.Series["DoanhThu"].Points.Clear();
            loadChart();
        }
    }
}
