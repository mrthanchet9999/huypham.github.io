using qlnt.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using qlnt.DB.Entity;

namespace qlnt.BUS
{
    class BangThuHoachBUS
    {
        public BangThuHoachBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void Add(BangThuHoach o)
        {

            BangThuHoachDB db = new BangThuHoachDB();
            db.Add(o);
        }
        public void Delete(string id)
        {
            BangThuHoachDB db = new BangThuHoachDB();
            db.Delete(id);
        }
        public void Edit(BangThuHoach o)
        {
            BangThuHoachDB db = new BangThuHoachDB();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            BangThuHoachDB db = new BangThuHoachDB();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid,int month,int year)
        {
            BangThuHoachDB db = new BangThuHoachDB();
            db.Search(dataGrid,month,year);
        }

    }
}
