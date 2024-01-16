using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Data
    {
        public DateTime data;

        public Data(int rok, int miesiac, int dzien)
        {
            data = new DateTime(rok, miesiac, dzien);
        }

        public void UstawBiezacaDate()
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

        public override string ToString()
        {
            return data.ToString("dd-MM-yyyy");
        }
    }
}
