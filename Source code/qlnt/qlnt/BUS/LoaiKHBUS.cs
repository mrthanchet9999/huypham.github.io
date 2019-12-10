using qlnt.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.BUS
{
    class LoaiKHBUS
    {
        LoaiKHDB db = new LoaiKHDB();
        public LoaiKHBUS()
        {

        }
        public Dictionary<int, string> View()
        {
            return db.View();
        }
    }
}
