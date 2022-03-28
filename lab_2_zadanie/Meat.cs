using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Meat : Product
    {
        private double weight;
        public double Weight { get; set; }

        public Meat(string name, double weight) : base (name)
        {
            Name = name;
            Weight = weight;    
        }

        public override void Print(string prefix)
        {
            base.Print(prefix); //not implemented
        }
    }
}
