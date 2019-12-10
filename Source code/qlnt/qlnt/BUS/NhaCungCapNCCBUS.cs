using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.Framework.UI;
using qlnt.DB;
using qlnt.DB.Entity;

namespace qlnt.BUS
{
    class NhaCungCapNCCBUS
    {
        public void View(BunifuCustomDataGrid dataGrid)
        {
            NhaCungCapDB db = new NhaCungCapDB();
            db.View(dataGrid);
        }

        public void Add(NhaCungCap ncc)
        {
            NhaCungCapDB db = new NhaCungCapDB();
            db.Add(ncc);
        }

        public void Delete(string ncc)
        {
            NhaCungCapDB db = new NhaCungCapDB();
            db.Delete(ncc);
        }

        public void Edit(NhaCungCap ncc)
        {
            NhaCungCapDB db = new NhaCungCapDB();
            db.Edit(ncc);
        }

        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            NhaCungCapDB db = new NhaCungCapDB();
            db.Search(dataGrid, s);
        }
    }
}
