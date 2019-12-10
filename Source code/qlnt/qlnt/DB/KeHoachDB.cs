using Bunifu.Framework.UI;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnt.DB
{
    class KeHoachDB
    {
        public KeHoachDB ()
        {

        }
        public KeHoach getKeHoach(string id)
        {
            QLNTEntities1 db = new QLNTEntities1();
            int ma = Convert.ToInt32(id);
            return db.KeHoach.Where(c => c.MaKeHoach == ma).SingleOrDefault();
        }
        public void getCTKeHoach(string id,BunifuCustomDataGrid dataGrid)
        {
            QLNTEntities1 db = new QLNTEntities1();
            int ma = Convert.ToInt32(id);
            var result = from c in db.ChiTietKH
                         join d in db.LoaiKH on c.MaLoai equals d.MaLoai
                         where c.MaKH == ma
                         select new { CongViec = d.TenLoai,HoanThanh=c.HoanThanh,MaLoai=c.MaLoai};
            dataGrid.DataSource= result.ToList();
        }
        public void setHoanThanh(ChiTietKH ct,bool value)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = ct.MaKH;
                
                ChiTietKH temp= db.ChiTietKH.Where(c=>c.MaLoai==ct.MaLoai && c.MaKH==ct.MaKH).SingleOrDefault();
                temp.HoanThanh = value;
                db.SaveChanges();
            }
        }
        public void setSoLuongCongViecHoanThanh(int MaKH)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                
                KeHoach k = db.KeHoach.Find(MaKH);
                int count = (from c in db.ChiTietKH where c.MaKH == MaKH && c.HoanThanh==true select c).Count();
                k.SoLuongCongViecHoanThanh = count;
                db.SaveChanges();
            }
        }
        public void setSoLuongCongViec(int MaKH)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {

                KeHoach k = db.KeHoach.Find(MaKH);
                int count = (from c in db.ChiTietKH where c.MaKH == MaKH select c).Count();
                k.SoLuongCongViec = count;
                db.SaveChanges();
            }
        }
        public int Add(KeHoach o, List<int> loai)
        {
            int idKH = 0;
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                db.KeHoach.Add(o);
                db.SaveChanges();

                db.Entry(o).GetDatabaseValues();
                idKH= o.MaKeHoach;



                // thêm trong chi tiết loại kế hoạch
                ChiTietKHDB ct = new ChiTietKHDB();
                ct.Add(loai, idKH);
            }
           
            return idKH;
        }
        public void Delete(string id)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                int ma = Convert.ToInt32(id);
                KeHoach temp = db.KeHoach.Where(p => p.MaKeHoach == ma).SingleOrDefault();
                db.KeHoach.Remove(temp);
                db.SaveChanges();
            }
        }
        public void Edit(int id,string noiDung, string chuThich)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                KeHoach temp = db.KeHoach.Find(id);
                temp.NoiDung = noiDung;
                temp.ChuThich = chuThich;
                db.SaveChanges();
            }
        }
        // thêm chi tiết kế hoạch chưa có
        public void ShowAddCtKH(int id,BunifuCustomDataGrid dataGrid)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                var result = from l in db.LoaiKH
                             where !(from c in db.ChiTietKH
                                     where c.MaKH == id
                                     select c.MaLoai
                                     ).Contains(l.MaLoai)
                             select new {MaLoai=l.MaLoai, CongViec=l.TenLoai };
                dataGrid.DataSource = result.ToList();
            }
        }
        
        public void View(BunifuCustomDataGrid dataGrid, DateTime d)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                //var result = from c in db.KeHoachs select new { TenPB=c.TenPB, Loai=c} ;
                
                var result = from c in db.KeHoach
                             where c.NgayThucHien.Month == d.Month &&  c.NgayThucHien.Year==d.Year                             
                             orderby c.NgayThucHien ascending
                             select new {
                                 MaKH =c.MaKeHoach,
                                 NgayTH =c.NgayThucHien.Day + "/" +c.NgayThucHien.Month +"/"+ c.NgayThucHien.Year ,
                                 TienDo =c.SoLuongCongViecHoanThanh +"/"+c.SoLuongCongViec ,
                                 TinhTrang=c.SoLuongCongViecHoanThanh < c.SoLuongCongViec ? "Chưa hoàn thành" :
                                            c.SoLuongCongViecHoanThanh == c.SoLuongCongViec ? "Hoàn thành" : "-"
                             };
                dataGrid.DataSource = result.ToList();
            }
        }
       

    }
}
