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
    class PhanBonBUS
    {
        public PhanBonBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void Add(PhanBon o)
        {

            PhanBonDB db = new PhanBonDB();
            db.Add(o);
        }
        public void Delete(string id)
        {
            PhanBonDB db = new PhanBonDB();
            db.Delete(id);
        }
        public void Edit(PhanBon o)
        {
            PhanBonDB db = new PhanBonDB();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            PhanBonDB db = new PhanBonDB();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid,string s)
        {
            PhanBonDB db = new PhanBonDB();
            db.Search(dataGrid,s);
        }
        public PhanBon getPhanBon(string id)
        {
            PhanBonDB db = new PhanBonDB();
            return db.getPhanBon(id);
        }
        // huy so luong phan bon qua han
        public List<HangHoa> getListPhanBon()
        {
            PhanBonDB db = new PhanBonDB();
            return db.getListPhanBon();
        }
        public void setHuySL(List<HangHoa> list)
        {
            PhanBonDB db = new PhanBonDB();
            foreach (var i in list)
            {
                if(i.loai.Equals("Phân bón"))
                    db.setHuySL(i.ma);
            }
        }
    }
}
