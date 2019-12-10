using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlnt.DB;
using Bunifu.Framework.UI;
using qlnt.DB.Entity;

namespace qlnt.BUS
{
    class KhachHangBUS
    {
        public void check()
        {
            checkString check = new checkString();
        }
        public KhachHangBUS()
        {

        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            KhachHangDB db = new KhachHangDB();
            db.View(dataGrid);
        }

        public void Add(KhachHang kh)
        { 
            KhachHangDB db = new KhachHangDB();
            db.Add(kh);
        }

        public void Delete(string id)
        {
            KhachHangDB db = new KhachHangDB();
            db.Delete(id);
        }
        public void Edit(KhachHang kh)
        {
            KhachHangDB db = new KhachHangDB();
            db.Edit(kh);
        }

        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            KhachHangDB db = new KhachHangDB();
            db.Search(dataGrid, s);
        }
    }
 
}
