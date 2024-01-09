using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IOsoba
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string ReturnFullName();

    }
}
