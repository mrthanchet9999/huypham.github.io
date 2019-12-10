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
    public partial class Dashboard : Form
    {
        public Dashboard(int authorization)
        {
            InitializeComponent();
            if (authorization != 0) fbtnEmployMngmt.Enabled = false;
            else fbtnEmployMngmt.Enabled = true;
            showPanels();
        }
        private void hidePanels()
        {
            pnlWeather.Visible = false;
            pnlToDoList.Visible = false;
            pnlStatistics.Visible = false;
            pnlClock.Visible = false;
        }

        private void showPanels()
        {
            
            //showing API Weather Panel
            APIWeather APIWeather = new APIWeather();
            APIWeather.TopLevel =  false;
            pnlWeather.Controls.Add(APIWeather);
            APIWeather.Show();
            pnlWeather.Visible = true;

            //showing today's To-do List Panel
            ToDoListPanel todo = new ToDoListPanel();
            todo.TopLevel = false;
            pnlToDoList.Controls.Add(todo);
            todo.BringToFront();
            todo.Show();
            pnlToDoList.Visible = true;

            //showing all time statistics Panel
            StatisticsPanel stat = new StatisticsPanel();
            load(pnlStatistics, stat);
            pnlStatistics.Visible = true;

            //i haven't had any great idea for this one yet
            ClockPanel clock = new ClockPanel();
            clock.TopLevel = false;
            pnlClock.Controls.Add(clock);
            clock.Show();
            pnlClock.Visible = true;
           
        }
        private void reloadPanels()
        {
            pnlClock.Visible = true;
            pnlWeather.Visible = true;
            pnlToDoList.Visible = true;
            pnlStatistics.Visible = true;
        }
        private void ibtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fbtnDashboard_Click(object sender, EventArgs e)
        {
            DashboardPanel dashboard = new DashboardPanel();
            dashboard.TopLevel = false;
            load(pnlMain, dashboard);
        }
        private void fbtnInformation_Click(object sender, EventArgs e)
        {
            hidePanels();
            FormCay info = new FormCay();
            info.TopLevel = false;
            load(pnlMain, info);
        }
        public void ftbnProductsSellingMngmt_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            hidePanels();
            ProductSellingMngmt psmngmt = new ProductSellingMngmt();
            load(pnlMain, psmngmt);
        }
        public void load(Panel panel, Form form)
        {
            panel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            panel.Controls.Add(form);
            form.Show();
        }
        private void fbtnWarehouseMngmt_Click(object sender, EventArgs e)
        {   
            hidePanels();
            WarehouseMngmtForm warehouse = new WarehouseMngmtForm();
            load(pnlMain, warehouse);
        }
        private void fbtnWorkMngmt_Click(object sender, EventArgs e)
        {
            hidePanels();
            FormKeHoach kehoach = new FormKeHoach();
            load(pnlMain, kehoach);
        }
        private void fbtnEmployMngmt_Click(object sender, EventArgs e)
        {
            hidePanels();
            FormNhanVien employee = new FormNhanVien();
            load(pnlMain, employee);
        }
        private void fbtnStatistics_Click(object sender, EventArgs e)
        {
            hidePanels();
            StatisticsForm stat = new StatisticsForm();
            load(pnlMain, stat);
        }

        private void fbtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
