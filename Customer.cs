using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Customer
    {
        public string FullName { get; set; }

        public Customer(string name)
        {
            FullName = name;
        }

        public override string ToString() => FullName;
    }
}
