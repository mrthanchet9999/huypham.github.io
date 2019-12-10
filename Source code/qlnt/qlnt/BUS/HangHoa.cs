using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlnt.BUS
{
    class HangHoa
    {
        public string ten { get; set; }
        public double SL { get; set; }// sản lượng nông sản hoặc số lượng hàng
        public string hanSD { get; set; }
        public string tinhTrang { get; set; }
        public int ma { get; set; }
        public string loai { get; set; }
        public HangHoa(){}
        public List<string> getListSearchName(List<HangHoa> list ,string name)
        {
            var result = from c in list
                         where (c.ten.ToUpper()).Contains(name.ToUpper()) 
                         select c.ten;
            return result.ToList();

        }
        public List<HangHoa> getListSearch(List<HangHoa> list, string name)
        {
            var result = from c in list
                         where (c.ten.ToUpper()).Contains(name.ToUpper())
                         select c;
            return result.ToList();

        }

    }
}
