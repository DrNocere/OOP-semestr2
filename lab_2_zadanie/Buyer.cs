using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadanie
{
    internal class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();
        public Buyer(string name, int age) : base (name, age)   
            {
                Name = name;
                Age = age;
            }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(int index)
        {
            throw new NotImplementedException();
        }

        public override void Print(string prefix)
        {
            base.Print(prefix); //not implemented
        }
    }
}
