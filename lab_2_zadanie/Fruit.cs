using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Fruit : Product
    {
        private int count;
        public int Count { get; set; }

        public Fruit(string name, int count) : base (name)
        {
            Name = name;
            Count = count;  
        }

        public override void Print(string prefix)
        {
            base.Print(prefix); //not implemented
        }
    }
}
