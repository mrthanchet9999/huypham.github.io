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
    class NongSanBUS
    {
        public NongSanBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void Add(NongSan o)
        {

            NongSanDB db = new NongSanDB();
            db.Add(o);
        }
        public void Delete(string id)
        {
            NongSanDB db = new NongSanDB();
            db.Delete(id);
        }
        public void Edit(NongSan o)
        {
            NongSanDB db = new NongSanDB();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            NongSanDB db = new NongSanDB();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            NongSanDB db = new NongSanDB();
            db.Search(dataGrid, s);
        }
        public string getNameNongSan(string id)
        {
            string ten;
            NongSanDB db = new NongSanDB();
            ten = db.getNameNongSan(id);
            return ten;
        }
        public NongSan getNongSan(string id)
        {
            NongSanDB db = new NongSanDB();
            return db.getNongSan(id);
        }
        // huy so luong phan bon qua han
        public List<HangHoa> getListNongSan()
        {
            NongSanDB db = new NongSanDB();
            return db.getListNongSan();
        }
        public void setHuySL(List<HangHoa> list)
        {
            NongSanDB db = new NongSanDB();
            foreach (var i in list)
            {
                if (i.loai.Equals("Nông sản"))
                    db.setHuySL(i.ma);
            }
        }

    }
}
