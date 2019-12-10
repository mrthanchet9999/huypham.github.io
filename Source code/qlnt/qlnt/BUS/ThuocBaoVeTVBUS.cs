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
    class ThuocBaoVeTVBUS
    {
        public ThuocBaoVeTVBUS() { }
        public void check()
        {
            checkString check = new checkString();
        }
        public void Add(ThuocBaoVeTV o)
        {

            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            db.Add(o);
        }
        public void Delete(string id)
        {
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            db.Delete(id);
        }
        public void Edit(ThuocBaoVeTV o)
        {
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            db.Edit(o);
        }

        public void View(BunifuCustomDataGrid dataGrid)
        {
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            db.View(dataGrid);
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            db.Search(dataGrid, s);
        }
        // huy so luong phan bon qua han
        public List<HangHoa> getListTBV()
        {
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            return db.getListTBV();
        }
        public void setHuySL(List<HangHoa> list)
        {
            ThuocBaoVeTVDB db = new ThuocBaoVeTVDB();
            foreach (var i in list)
            {
                if (i.loai.Equals("Thuốc BVTV"))
                    db.setHuySL(i.ma);
            }
        }
    }
}
