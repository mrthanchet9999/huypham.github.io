using qlnt.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.UI.DialogForm
{
    public partial class Dialog_AddCTKH : Form
    {
        KeHoachBUS bus = new KeHoachBUS();
        int maKH; // id của kế hoạch
        public Dialog_AddCTKH()
        {
            InitializeComponent();
            border();
        }

        public Dialog_AddCTKH(int id)
        {
            maKH = id;
            InitializeComponent();
            border();
            bus.ShowAddCtKH(id, dataGrid);
        }
        private void Dialog_AddCTKH_Load(object sender, EventArgs e)
        {
            
        }
        
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid.Columns[e.ColumnIndex].Name == "Add")
            {
                int maLoai=Convert.ToInt32(dataGrid.Rows[e.RowIndex].Cells["MaLoai"].Value);
                bus.AddCtKH(maKH, maLoai);
                bus.ShowAddCtKH(maKH, dataGrid);
            }
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
