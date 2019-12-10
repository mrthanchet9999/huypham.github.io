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
    class NongSanDB
    {
        public NongSanDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result=from c in db.NongSan 
                           join dbcay in db.Cay on c.MaLoaiCay equals dbcay.MaLoaiCay 
                           select new { 
                               TenCay=dbcay.TenCay,
                               ThoiGianBaoQuan = c.ThoiGianBaoQuan, 
                               SanLuongTonKho = c.SanLuongTonKho, 
                               DonGia = c.DonGia, 
                           };
                //var result = from c in db.NongSan select new { ThoiGianBaoQuan = c.ThoiGianBaoQuan, SanLuongTonKho = c.SanLuongTonKho, DonGia = c.DonGia, BaoQuan=c.BaoQuan,MaLoaiCay=c.MaLoaiCay };
                d.DataSource = result.ToList();
            }
        }
        public NongSan getNongSan(string id)
        {
            NongSan o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.NongSans.Find();
                int ma=Convert.ToInt32(id);
                o = db.NongSan.Where(p => p.MaNS == ma).SingleOrDefault();

            }
            return o;
        }
        public string getNameNongSan(string id)
        {
            Cay cay;
            NongSan ns ;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.NongSans.Find();
                int ma = Convert.ToInt32(id);

                ns = db.NongSan.Where(p => p.MaNS == ma).SingleOrDefault();

                ma = ns.MaLoaiCay;
                cay = db.Cay.Where(p=> p.MaLoaiCay == ma).SingleOrDefault();
            }
            return cay.TenCay;
        }
        public void Add(NongSan o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.NongSans.Add(new NongSan() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.NongSan.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                NongSan temp = db.NongSan.Where(p => p.MaNS == ma).SingleOrDefault();
                db.NongSan.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(NongSan o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaNS;
                NongSan temp = db.NongSan.Find(ma);
                temp.ThoiGianBaoQuan = o.ThoiGianBaoQuan;
                temp.SanLuongTonKho = o.SanLuongTonKho;
                temp.DonGia = o.DonGia;
                temp.MaLoaiCay = o.MaLoaiCay;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.NongSans select new { TenPB=c.TenPB, Loai=c} ;
                //var result = from c in db.NongSan join d in db.Cay on c.MaLoaiCay equals d.MaLoaiCay
                //var result = from c in db.NongSan
                //             select new { ThoiGianBaoQuan = c.ThoiGianBaoQuan, SanLuongTonKho = c.SanLuongTonKho, DonGia = c.DonGia, BaoQuan = c.BaoQuan};
                var result = from c in db.NongSan
                             join dbcay in db.Cay on c.MaLoaiCay equals dbcay.MaLoaiCay
                             select new
                             {
                                 MaNS=c.MaNS,
                                 TenCay = dbcay.TenCay,
                                 ThoiGianBaoQuan = c.ThoiGianBaoQuan,
                                 SanLuongTonKho = c.SanLuongTonKho,
                                 DonGia = c.DonGia,
                             };
                dataGrid.DataSource = result.ToList();
            }
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                /*var result = from c in db.NongSan
                              where c./*Tencay.Contains(s)
                              select new { TenPB = c.TenPB, Loai = c.Loai, KhoiLuong = c.KhoiLuong.ToString(), SoLuong = c.SoLuong, DonGia = c.DonGia, NgaySX = c.NgaySX.Day + "/" + c.NgaySX.Month + "/" + c.NgaySX.Year, HanSD = c.HanSD.Day + "/" + c.HanSD.Month + "/" + c.HanSD.Year, MaPB = c.MaPB };
                dataGrid.DataSource = result.ToList();*/
                var result = from c in db.NongSan
                             join dbcay in db.Cay on c.MaLoaiCay equals dbcay.MaLoaiCay
                             where dbcay.TenCay.Contains(s)
                             select new
                             {
                                 MaNS = c.MaNS,
                                 TenCay = dbcay.TenCay,
                                 ThoiGianBaoQuan = c.ThoiGianBaoQuan,
                                 SanLuongTonKho = c.SanLuongTonKho,
                                 DonGia = c.DonGia,
                             };
                dataGrid.DataSource = result.ToList();
            }
        }
        public List<HangHoa> getListNongSan()
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = db.getListNongSan();
                List<HangHoa> l = new List<HangHoa>();
                foreach (var item in result)
                {
                    HangHoa h = new HangHoa();
                    h.ten = item.TenNS;
                    h.hanSD = item.HanSD.Value.ToString("dd/MM/yyyy");
                    h.SL = item.SanLuong;
                    h.ma = item.MaNS;
                    h.loai = "Nông sản";
                    string trangThai = "Còn hàng";
                    if (item.SanLuong == 0)
                    {
                        trangThai = "Hết hàng";
                        h.hanSD = "-";
                    }
                    else
                        if (item.SanLuong < 100)
                        trangThai = "Sắp hết hàng";
                    if (DateTime.Compare(item.HanSD.Value, DateTime.Now) == -1 && item.SanLuong != 0)
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
                NongSan p = db.NongSan.Where(c => c.MaNS == id).SingleOrDefault();
                p.SanLuongTonKho = 0;
                db.SaveChanges();
            }
        }

    }
}
