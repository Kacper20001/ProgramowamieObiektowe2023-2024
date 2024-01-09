using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IStudent : IOsoba 
    { 
        string University { get; set; }
        string Course { get; set; }
        string Year {  get; set; }
        string Semester { get; set; }
    }
}
