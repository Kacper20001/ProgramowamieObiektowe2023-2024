using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shape
    {
        public double x;
        public double y;
        public double height;
        public double width;
       public virtual void Draw()
        {
            Console.WriteLine("Draw Shape");
        }
    }
}
