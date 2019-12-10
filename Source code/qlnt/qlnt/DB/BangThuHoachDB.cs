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
    class BangThuHoachDB
    {
        public BangThuHoachDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from bth in db.BangThuHoach
                             join ctth in db.ChiTiet_TH on bth.MaBang equals ctth.MaBang
                             join ns in db.NongSan on ctth.MaNS equals ns.MaNS
                             join nv in db.NhanVien on bth.MaNV equals nv.MaNV
                             join c in db.Cay on ns.MaLoaiCay equals c.MaLoaiCay
                             select new
                             {
                                 TenCay = c.TenCay,
                                 NgayThuHoach = bth.NgayThuHoach,
                                 SanLuongThuHoach = ctth.SanLuongThuHoach,
                                 SanLuongThietHai = ctth.SanLuongThietHai,
                                 //TenNV = nv.TenNV
                             };
                d.DataSource = result.ToList();
            }
            
        }
        public BangThuHoach GetBangThuHoach(string id)
        {
            BangThuHoach o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma=Convert.ToInt32(id);
                o = db.BangThuHoach.Where(p => p.MaBang == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(BangThuHoach o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.BangThuHoach.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                BangThuHoach temp = db.BangThuHoach.Where(p => p.MaBang == ma).SingleOrDefault();
                db.BangThuHoach.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(BangThuHoach o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaBang;
                BangThuHoach temp = db.BangThuHoach.Find(ma);
                temp.NgayThuHoach = o.NgayThuHoach;
                temp.MaNV = o.MaNV;
                db.SaveChanges();
            }
        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;
                var result = from bth in db.BangThuHoach
                             join ctth in db.ChiTiet_TH on bth.MaBang equals ctth.MaBang
                             join nv in db.NhanVien on bth.MaNV equals nv.MaNV
                             join ns in db.NongSan on ctth.MaNS equals ns.MaNS
                             join c in db.Cay on ns.MaLoaiCay equals c.MaLoaiCay
                             group new { ctth, bth, nv } by new { bth.NgayThuHoach, bth.MaBang,nv.TenNV } into ctthGroup
                             select new {
                                 TenNV = ctthGroup.Key.TenNV,
                                 NgayThuHoach = ctthGroup.Key.NgayThuHoach,
                                 MaBang=ctthGroup.Key.MaBang,
                                 SanLuongThuHoach = ctthGroup.Sum(c => c.ctth.SanLuongThuHoach),
                                 SanLuongThietHai= ctthGroup.Sum(c => c.ctth.SanLuongThietHai)
                             };
                dataGrid.DataSource = result.ToList();
            }
        }
        public void Search(BunifuCustomDataGrid dataGrid, int month,int year)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {

                var result = from bth in db.BangThuHoach
                             join ctth in db.ChiTiet_TH on bth.MaBang equals ctth.MaBang
                             join ns in db.NongSan on ctth.MaNS equals ns.MaNS
                             join nv in db.NhanVien on bth.MaNV equals nv.MaNV
                             join c in db.Cay on ns.MaLoaiCay equals c.MaLoaiCay
                             where bth.NgayThuHoach.Month == month && bth.NgayThuHoach.Year==year
                             select new
                             {
                                 TenNV = nv.TenNV,
                                 NgayThuHoach = bth.NgayThuHoach,
                                 SanLuongThuHoach = ctth.SanLuongThuHoach,
                                 SanLuongThietHai = ctth.SanLuongThietHai,
                                 MaBang = bth.MaBang,
                                 
                             };
                dataGrid.DataSource = result.ToList();
            }
        }
    }
}
