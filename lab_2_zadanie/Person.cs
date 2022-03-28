using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine(prefix + $"{name} ({age} y.o.)");
        }
    }
}
