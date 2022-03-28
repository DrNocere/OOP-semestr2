using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Shop : IThing
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
            string prefix = "\t";
            //string prefix = ">>> "; //prefix can be easily exchanged by modifying the value of the 'prefix' variable

            Console.WriteLine($"Shop: {Name}");
            if(people.Length > 0)
            {
                Console.WriteLine("-- People: --");
                foreach(Person person in people)
                {
                    person.Print(prefix);
                }
            }
            if (products.Length > 0)
            {
                Console.WriteLine("-- Products: --");
                foreach (Product product in products)
                {
                    product.Print(prefix);
                }
            }
        }
    }
}
