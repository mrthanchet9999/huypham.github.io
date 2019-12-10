using qlnt.DB;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.BUS
{
    class LoaiKHDB
    {
        public Dictionary<int, string> View()
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;

                Dictionary<int,string> d = db.LoaiKH.Select(t => new { t.MaLoai, t.TenLoai }).ToDictionary(t => t.MaLoai,t=>t.TenLoai); ;

                return d;
            }
        }
    }
}
