using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop
    {
        private string name;
        public string Name { get; set; }
        Person[] people = new Person[0];
        Product[] products = new Product[0];

        public Shop(string name, Person[] people, Product[] products)
        {
            Name = name;
            this.people = people;  
            this.products = products;
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
