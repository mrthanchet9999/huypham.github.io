using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace qlnt.BUS
{
    class checkString
    {
        public checkString() { }
            
        public bool isNUll(string t)
        {
            
            if (t.Equals(""))
            {
                return true;
            }
            return false;
        }
        public bool checkLength(string t, int lengthMin, int lengthMax)
        {
            Regex regex = new Regex(@"[a-zA-Z]{"+lengthMin+","+lengthMax+"}");
            return regex.IsMatch(t);
        }
       
        public bool isNumber(string t)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(t);
        }
    }
}
