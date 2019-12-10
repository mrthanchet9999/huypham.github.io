using Bunifu.Framework.UI;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DB
{
    class NhanVienDB
    {
        public Dictionary<int, string> getListQuyen()
        {
            QLNTEntities1 db = new QLNTEntities1();
            return (from c in db.Quyen where c.MaQuyen!=1 select new { c.MaQuyen, c.TenChucVu }).ToDictionary(c => c.MaQuyen, c => c.TenChucVu);
        }

        public void View(BunifuCustomDataGrid dataGid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.NhanVien
                             join q in db.Quyen on c.MaQuyen equals q.MaQuyen
                             where q.MaQuyen !=1
                             select new { TenNV = c.TenNV, SoDienThoai = c.SoDienThoai, DiaChi = c.DiaChi, MatKhau = c.MatKhau, MaNV = c.MaNV, TenChucVu = q.TenChucVu, MaQuyen = q.MaQuyen };
                dataGid.DataSource = result.ToList();
            }
        }

        public void Add(NhanVien nv)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.NhanVien.Add(nv);
                db.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                NhanVien nv = db.NhanVien.Where(p => p.MaNV == ma).SingleOrDefault();
                db.NhanVien.Remove(nv);
                db.SaveChanges();
            }
        }

        public NhanVien getNhanVien(string id)
        {
            NhanVien nv;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                nv = db.NhanVien.Where(p => p.MaNV == ma).SingleOrDefault();
            }
            return nv;
        }

        public void Edit(NhanVien nv)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = nv.MaNV;
                NhanVien temp = db.NhanVien.Find(ma);
                temp.TenNV = nv.TenNV;
                temp.SoDienThoai = nv.SoDienThoai;
                temp.DiaChi = nv.DiaChi;
                temp.MatKhau = nv.MatKhau;
                temp.MaQuyen = nv.MaQuyen;
                db.SaveChanges();
            }
        }

        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from nv in db.NhanVien
                             join q in db.Quyen on nv.MaQuyen equals q.MaQuyen
                             where nv.TenNV.Contains(s) && nv.MaNV != 1
                             select new
                             {
                                 MaNV = nv.MaNV,
                                 TenNV = nv.TenNV,
                                 SoDienThoai = nv.SoDienThoai,
                                 DiaChi = nv.DiaChi,
                                 MatKhau = nv.MatKhau,
                                 MaQuyen = q.MaQuyen,
                                 TenChucVu = q.TenChucVu
                             };
                dataGrid.DataSource = result.ToList();
            }
        }
    }
}
