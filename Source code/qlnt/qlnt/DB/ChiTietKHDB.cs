using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qlnt.DB.Entity;

namespace qlnt.DB
{
    class ChiTietKHDB
    {
        public ChiTietKHDB()
        {

        }
        public void Add(List<int> loai,int idKH)
        {
            QLNTEntities1 db = new QLNTEntities1();
            List<ChiTietKH> l = new List<ChiTietKH>();
            foreach(int i in loai)
            {
                ChiTietKH temp = new ChiTietKH();
                temp.MaKH = idKH;
                temp.MaLoai = i;
                temp.HoanThanh = false;
                db.ChiTietKH.Add(temp);
            }
            db.SaveChanges();


            //l.Add(temp);


        }
        public void Add(int maKH, int maLoai)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                ChiTietKH c = new ChiTietKH();
                c.MaKH = maKH;
                c.MaLoai = maLoai;
                c.HoanThanh = false;
                db.ChiTietKH.Add(c);
                db.SaveChanges();

            }
        }public void Delete(int maKH,int maLoai)
        {
            using (QLNTEntities1 db = new QLNTEntities1())
            {
                ChiTietKH ct = db.ChiTietKH.Where(c=>c.MaKH==maKH && c.MaLoai==maLoai).SingleOrDefault();
                db.ChiTietKH.Remove(ct);
                db.SaveChanges();

            }
        }

    }
}
