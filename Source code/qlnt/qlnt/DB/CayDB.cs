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
    class CayDB
    {
        public CayDB() { }
        public void load ( DataGridView d)
        {
            // DataSet data = new DataSet();
            //QLNTEntities1 db = new QLNTEntities1();
            
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var result = from c in db.Cay select new {MaLoaiCay=c.MaLoaiCay, TenCay = c.TenCay, SoLuong = c.SoLuong,MuaThuHoach=c.MuaThuHoach,NamTrongCay=c.NamTrongCay };
                d.DataSource = result.ToList();
            }
        }
        public Cay GetCay(string id)
        {
            Cay o;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //p= db.PhanBons.Find();
                int ma=Convert.ToInt32(id);
                o = db.Cay.Where(p => p.MaLoaiCay == ma).SingleOrDefault();
            }
            return o;
        }
        public void Add(Cay o)
        {
            /*using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                db.PhanBons.Add(new PhanBon() { TenPB ="Nis", Loai="Vô cơ", NgaySX= new DateTime(2019,7,1),HanSD = new  DateTime(2020, 7, 1),SoLuong=12,DonGia=100000,KhoiLuong=500 });
                db.SaveChanges();
            }*/
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.Cay.Add(o);
                db.SaveChanges();
            }
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                Cay temp = db.Cay.Where(p => p.MaLoaiCay == ma).SingleOrDefault();
                db.Cay.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(Cay o)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = o.MaLoaiCay;
                Cay temp = db.Cay.Find(ma);
                temp.TenCay = o.TenCay;
                temp.SoLuong = o.SoLuong;
                temp.MuaThuHoach = o.MuaThuHoach;
                temp.NamTrongCay = o.NamTrongCay;
                db.SaveChanges();
            }
        }
        public Dictionary<int,string> getAllName()
        {
            Dictionary<int, string> d;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                d=(
                    from c in db.Cay
                    select new {c.MaLoaiCay,c.TenCay}
                    
                    ).ToDictionary(c => c.MaLoaiCay, c => c.TenCay);
            }
            return d;

        }
        public void View(BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.PhanBons select new { TenPB=c.TenPB, Loai=c} ;
                var result = from c in db.Cay
                             select new { TenCay = c.TenCay, SoLuong = c.SoLuong, MuaThuHoach = c.MuaThuHoach, NamTrongCay = c.NamTrongCay,MaLoaiCay=c.MaLoaiCay};
                dataGrid.DataSource = result.ToList();
            }
        }
        public void Search(BunifuCustomDataGrid dataGrid, string s)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from c in db.Cay
                              where c.TenCay.Contains(s)
                              select new { TenCay = c.TenCay, SoLuong = c.SoLuong, MuaThuHoach = c.MuaThuHoach, NamTrongCay = c.NamTrongCay,MaLoaiCay=c.MaLoaiCay };
                dataGrid.DataSource = result.ToList();
            }
        }
        
    }
}
