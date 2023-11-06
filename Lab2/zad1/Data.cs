using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Data
    {
        public DateTime data;

        public Data()
        {
            data = DateTime.Now;
        
        }
         public void PrzesunTydzien()
        {
            data = data.AddDays(7);
        }
        
        public void CofnijTydzien()
        {
            data = data.AddDays(-7);
        }
    }
}
