using Bunifu.Framework.UI;
using qlnt.DB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.DB
{
    class KeHoachBUS
    {
        
        public KeHoachBUS() { }
        public int Add(KeHoach kh,  List<int> loai)
        {
            KeHoachDB db = new KeHoachDB();
            return db.Add(kh,loai);

        }
        public KeHoach getKeHoach(string id)
        {
            KeHoachDB db = new KeHoachDB();
            return db.getKeHoach(id);
        }
        public void getCTKeHoach(string id,BunifuCustomDataGrid dataGrid)
        {
            KeHoachDB db = new KeHoachDB();
            db.getCTKeHoach(id,dataGrid);
        }
        public void View(BunifuCustomDataGrid dataGrid, DateTime d)
        {
            KeHoachDB db = new KeHoachDB();
            db.View(dataGrid,d);
        }
        public void setHoanHanh(ChiTietKH ct,bool value)
        {
            KeHoachDB db = new KeHoachDB();
            db.setHoanThanh(ct,value);
            db.setSoLuongCongViecHoanThanh(ct.MaKH);
        }
        public void Edit(int id,string noiDung,string chuThich)
        {
            KeHoachDB db = new KeHoachDB();
            db.Edit(id, noiDung, chuThich);
        }
        public void ShowAddCtKH (int id,BunifuCustomDataGrid dataGrid)
        {
            KeHoachDB db = new KeHoachDB();
            db.ShowAddCtKH(id,dataGrid);
        }
        public void AddCtKH(int maKH,int maLoai)
        {
            ChiTietKHDB db = new ChiTietKHDB();
            db.Add(maKH,maLoai);
            KeHoachDB db1 = new KeHoachDB();
            db1.setSoLuongCongViec(maKH);
            db1.setSoLuongCongViecHoanThanh(maKH);
        }
        public void DeleteCtKH(int maKH,int maLoai)
        {
            ChiTietKHDB db = new ChiTietKHDB();
            db.Delete(maKH, maLoai);
            KeHoachDB db1 = new KeHoachDB();
            db1.setSoLuongCongViec(maKH);
            db1.setSoLuongCongViecHoanThanh(maKH);
        }
    }
}
