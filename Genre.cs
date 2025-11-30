using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Genre
    {
        public string Name { get; set; }

        public Genre(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}