using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ulamek a = new Ulamek(1, 2);
            Ulamek b = new Ulamek(3, 4);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);

            Ulamek c = new Ulamek(-2, -4);
            Console.WriteLine($"Ulamek c: {c}");
            /*
            Ulamek[] kk = new Ulamek[]
            {
                new Ulamek(1, 2),
                new Ulamek(1, 3),
                new Ulamek(10, 2),
                new Ulamek(3, 2),
                new Ulamek()
            };

            
            Array.Sort(kk);

            /*
            Comparison<T> comparison = (a, b) =>
            {
                return a.Licznik - b.Licznik;
            };


            if (comparison.Invoke(a, b))
            {

            }


            Array.Sort(kk, comparison);
            */
        }
    }
}
