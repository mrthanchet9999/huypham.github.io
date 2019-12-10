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
    public partial class DashboardPanel : Form
    {
        public DashboardPanel()
        {
            InitializeComponent();
            showPanels();
        }
        private void showPanels()
        {
            //showing API Weather Panel
            APIWeather APIWeather = new APIWeather();
            APIWeather.TopLevel = false;
            pnlWeather.Controls.Add(APIWeather);
            APIWeather.Show();
            //pnlWeather.Visible = true;

            //showing today's To-do List Panel
            ToDoListPanel todo = new ToDoListPanel();
            todo.TopLevel = false;
            pnlToDoList.Controls.Add(todo);
            todo.BringToFront();
            todo.Show();
            //pnlToDoList.Visible = true;

            //showing all time statistics Panel
            StatisticsPanel stat = new StatisticsPanel();
            stat.TopLevel = false;
            pnlStatistics.Controls.Add(stat);
            stat.BringToFront();
            stat.Show();
            pnlStatistics.Visible = true;

            //i haven't had any great idea for this one yet
            ClockPanel clock = new ClockPanel();
            clock.TopLevel = false;
            pnlClock.Controls.Add(clock);
            clock.Show();
            pnlClock.Visible = true;
        }
    }
}
