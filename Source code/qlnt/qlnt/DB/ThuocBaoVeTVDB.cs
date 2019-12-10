using Bunifu.Framework.UI;
using qlnt.BUS;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.DB
{
    class ThuocBaoVeTVDB
    {
        public ThuocBaoVeTVDB() { }
        public void load(DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();

            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from c in db.ThuocBaoVeTV select new { TenThuoc = c.TenThuoc, ThoiGianCachLy = c.ThoiGianCachLy, NoiSX = c.NoiSX, Dang = c.Dang, SoLuong = c.SoLuong, CongDung = c.CongDung, NgaySX = c.NgaySX, HanSD = c.HanSD, MaThuoc = c.MaThuoc, MaDoc = c.MaDoc };
                d.DataSource = result.ToList();
            }
        }
        public ThuocBaoVeTV GetThuocBaoVeTV(string id)
        {
            ThuocBaoVeTV o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma = Convert.ToInt32(id);
                o = db.ThuocBaoVeTV.Where(p => p.MaThuoc == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(ThuocBaoVeTV o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.ThuocBaoVeTV.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                ThuocBaoVeTV temp = db.ThuocBaoVeTV.Where(p => p.MaThuoc == ma).SingleOrDefault();
                db.ThuocBaoVeTV.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(ThuocBaoVeTV o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaThuoc;
                ThuocBaoVeTV temp = db.ThuocBaoVeTV.Find(ma);
                temp.TenThuoc = o.TenThuoc;
                temp.ThoiGianCachLy = o.ThoiGianCachLy;
                temp.NoiSX = o.NoiSX;
                temp.Dang = o.Dang;
                temp.SoLuong = o.SoLuong;
                temp.CongDung = o.CongDung;
                temp.NgaySX = o.NgaySX;
                temp.HanSD = o.HanSD;
                temp.MaDoc = o.MaDoc;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;

                var result = from c in db.ThuocBaoVeTV
                             select new { TenThuoc = c.TenThuoc, ThoiGianCachLy = c.ThoiGianCachLy, NoiSX = c.NoiSX, Dang = c.Dang, SoLuong = c.SoLuong, CongDung = c.CongDung, NgaySX = c.NgaySX, HanSD = c.HanSD, MaThuoc = c.MaThuoc, MaDoc = c.MaDoc };
                dataGrid.DataSource = result.ToList();
            }
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.ThuocBaoVeTV
                             where c.TenThuoc.Contains(s)
                             select new { TenThuoc = c.TenThuoc, ThoiGianCachLy = c.ThoiGianCachLy, NoiSX = c.NoiSX, Dang = c.Dang, SoLuong = c.SoLuong, CongDung = c.CongDung, NgaySX = c.NgaySX, HanSD = c.HanSD, MaThuoc = c.MaThuoc, MaDoc = c.MaDoc };
                dataGrid.DataSource = result.ToList();
            }
        }
        public List<HangHoa> getListTBV()
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.ThuocBaoVeTV
                             select c;
                List<HangHoa> l = new List<HangHoa>();
                foreach (var item in result)
                {
                    HangHoa h = new HangHoa();
                    h.ten = item.TenThuoc;
                    h.hanSD = item.HanSD.ToString("dd/MM/yyyy");
                    h.SL = item.SoLuong;
                    h.ma = item.MaThuoc;
                    h.loai = "Thuốc BVTV";
                    string trangThai = "Còn hàng";
                    if (item.SoLuong == 0)
                    {
                        trangThai = "Hết hàng";
                        h.hanSD = "-";
                    }
                    else
                        if (item.SoLuong < 10)
                        trangThai = "Sắp hết hàng";
                    if (DateTime.Compare(item.HanSD, DateTime.Now) == -1 && item.SoLuong != 0)
                        trangThai = "Hết hạn sử dụng";
                    h.tinhTrang = trangThai;
                    l.Add(h);
                }
                return l;
            }
        }
        public void setHuySL(int id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                ThuocBaoVeTV p = db.ThuocBaoVeTV.Where(c => c.MaThuoc == id).SingleOrDefault();
                p.SoLuong = 0;
                db.SaveChanges();
            }
        }
    }
}
