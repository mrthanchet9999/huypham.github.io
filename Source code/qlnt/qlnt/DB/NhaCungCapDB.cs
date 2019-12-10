using Bunifu.Framework.UI;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace qlnt.DB
{
    class NhaCungCapDB
    {
        public void View(BunifuCustomDataGrid dataGid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.NhaCungCap
                             select new { TenNCC = c.TenNCC, SoDienThoai = c.SoDienThoai, DiaChi = c.DiaChi, MaNCC = c.MaNCC };
                dataGid.DataSource = result.ToList();
            }
        }

        public void Add(NhaCungCap ncc)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.NhaCungCap.Add(ncc);
                db.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                NhaCungCap ncc = db.NhaCungCap.Where(p => p.MaNCC == ma).SingleOrDefault();
                db.NhaCungCap.Remove(ncc);
                db.SaveChanges();
            }
        }

        public NhaCungCap getNhaCungCap(string id)
        {
            NhaCungCap ncc;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                ncc = db.NhaCungCap.Where(p => p.MaNCC == ma).SingleOrDefault();
            }
            return ncc;
        }

        public void Edit(NhaCungCap ncc)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = ncc.MaNCC;
                NhaCungCap temp = db.NhaCungCap.Find(ma);
                temp.TenNCC = ncc.TenNCC;
                temp.SoDienThoai = ncc.SoDienThoai;
                temp.DiaChi = ncc.DiaChi;
                db.SaveChanges();
            }
        }

        public void Search(BunifuCustomDataGrid dataGid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.NhaCungCap
                             where c.TenNCC.Contains(s)
                             select new
                             {
                                 MaNCC = c.MaNCC,
                                 TenNCC = c.TenNCC,
                                 SoDienThoai = c.SoDienThoai,
                                 DiaChi = c.DiaChi
                             };
                dataGid.DataSource = result.ToList();
            }
        }
    }
}
