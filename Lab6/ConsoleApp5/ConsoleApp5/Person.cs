using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public record Person
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }
    }
}
