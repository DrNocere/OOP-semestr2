using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Product : IThing
    {
        private string name;
        public string Name { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine(prefix + $"{name}");
        }
    }
}
