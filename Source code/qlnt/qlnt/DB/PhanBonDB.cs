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
    class PhanBonDB
    {
        public PhanBonDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from c in db.PhanBon select new { TenPB = c.TenPB, Loai = c.Loai };
                d.DataSource = result.ToList();
            }
        }
        public PhanBon getPhanBon(string id)
        {
            PhanBon o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma=Convert.ToInt32(id);
                o = db.PhanBon.Where(p => p.MaPB == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(PhanBon o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.PhanBon.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                PhanBon temp = db.PhanBon.Where(p => p.MaPB == ma).SingleOrDefault();
                db.PhanBon.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(PhanBon o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaPB;
                PhanBon temp = db.PhanBon.Find(ma);
                temp.TenPB = o.TenPB;
                temp.Loai = o.Loai;
                temp.SoLuong = o.SoLuong;
                temp.KhoiLuong = o.KhoiLuong;
                temp.NgaySX = o.NgaySX;
                temp.HanSD = o.HanSD;
                temp.DonGia = o.DonGia;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;
                var result = from c in db.PhanBon
                             select new { TenPB = c.TenPB, Loai = c.Loai,KhoiLuong = c.KhoiLuong.ToString(), SoLuong = c.SoLuong, DonGia = c.DonGia, NgaySX = c.NgaySX.Day+"/"+ c.NgaySX.Month +"/"+ c.NgaySX.Year,HanSD=  c.HanSD.Day+"/"+c.HanSD.Month +"/"+ c.HanSD.Year ,MaPB=c.MaPB};
                dataGrid.DataSource = result.ToList();
            }
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.PhanBon
                              where c.TenPB.Contains(s)
                              select new { TenPB = c.TenPB, Loai = c.Loai, KhoiLuong = c.KhoiLuong.ToString(), SoLuong = c.SoLuong, DonGia = c.DonGia, NgaySX = c.NgaySX.Day + "/" + c.NgaySX.Month + "/" + c.NgaySX.Year, HanSD = c.HanSD.Day + "/" + c.HanSD.Month + "/" + c.HanSD.Year, MaPB = c.MaPB };
                dataGrid.DataSource = result.ToList();
            }
        }
        public List<HangHoa> getListPhanBon()
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.PhanBon
                             select c;
                List<HangHoa> l = new List<HangHoa>();
                foreach (var item in result)
                {
                    HangHoa h = new HangHoa();
                    h.ten = item.TenPB;
                    h.hanSD = item.HanSD.ToString("dd/MM/yyyy");
                    h.SL = item.SoLuong;
                    h.ma = item.MaPB;
                    h.loai = "Phân bón";
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
                PhanBon p = db.PhanBon.Where(c => c.MaPB == id).SingleOrDefault();
                p.SoLuong = 0;
                db.SaveChanges();
            }
        }

    }
}
