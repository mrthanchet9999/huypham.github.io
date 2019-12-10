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
    class CayBUS
    {
        public CayBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void Add(Cay o)
        {

            CayDB db = new CayDB();
            db.Add(o);
        }
        public void Delete(string id)
        {
            CayDB db = new CayDB();
            db.Delete(id);
        }
        public void Edit(Cay o)
        {
            CayDB db = new CayDB();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            CayDB db = new CayDB();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid,string s)
        {
            CayDB db = new CayDB();
            db.Search(dataGrid,s);
        }
        public Dictionary<int,string> getAllNameTree()
        {
            CayDB db = new CayDB();
            return db.getAllName();
        }

    }
}
