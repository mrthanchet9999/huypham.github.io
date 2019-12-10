using Bunifu.Framework.UI;
using qlnt.DB;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.BUS
{
    class NhanVienBUS
    {
        public void View(BunifuCustomDataGrid dataGrid)
        {
            NhanVienDB db = new NhanVienDB();
            db.View(dataGrid);
        }

        public void Add(NhanVien nv)
        {
            NhanVienDB db = new NhanVienDB();
            db.Add(nv);
        }

        public void Delete(string nv)
        {
            NhanVienDB db = new NhanVienDB();
            db.Delete(nv);
        }

        public void Edit(NhanVien nv)
        {
            NhanVienDB db = new NhanVienDB();
            db.Edit(nv);
        }

        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            NhanVienDB db = new NhanVienDB();
            db.Search(dataGrid, s);
        }
    }
}
