﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Seller : Person
    {
        public Seller(string name, int age) : base (name, age)  
        {
            Name = name;
            Age = age;  
        }

        public override void Print(string prefix)
        {
            base.Print(prefix); //not implemented
        }
    }
}
