using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlnt.BUS;
using Bunifu.Framework.UI;
using System.Globalization;
using System.Data;
using qlnt.DB.Entity;

namespace qlnt.DB
{
    class KhachHangDB
    {
        public void View(BunifuCustomDataGrid dataGid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;
                var result = from c in db.KhachHang
                             select new { TenKH = c.TenKH, DienThoai = c.DienThoai, DiaChi = c.DiaChi, MaKH = c.MaKH };
                dataGid.DataSource = result.ToList();
            }
        }

        public void Add(KhachHang kh)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.KhachHang.Add(kh);
                db.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                KhachHang temp = db.KhachHang.Where(p => p.MaKH == ma).SingleOrDefault();
                db.KhachHang.Remove(temp);
                db.SaveChanges();
            }
        }
        public KhachHang getKhachHang(string id)
        {
            KhachHang kh;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma = Convert.ToInt32(id);
                kh = db.KhachHang.Where(p => p.MaKH == ma).SingleOrDefault();
            }
            return kh;
        }

        public void Edit(KhachHang kh)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = kh.MaKH;
                KhachHang temp = db.KhachHang.Find(ma);
                temp.TenKH = kh.TenKH;
                temp.DienThoai = kh.DienThoai;
                temp.DiaChi = kh.DiaChi;
                db.SaveChanges();
            }
        }

        public void Search(BunifuCustomDataGrid dataGid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.KhachHang
                             where c.TenKH.Contains(s)
                             select new { 
                                 MaKH=c.MaKH,
                                 TenKH = c.TenKH,
                                 DienThoai = c.DienThoai, 
                                 DiaChi = c.DiaChi};
                dataGid.DataSource = result.ToList();
            }
        }
    }
}

