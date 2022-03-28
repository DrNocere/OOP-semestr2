using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public readonly struct Ulamek : IEquatable<Ulamek>, IComparable<Ulamek>
    {
        public BigInteger Licznik { get; init; } = 1;
        public BigInteger Mianownik { get; init; } = 1;
        #region constants
        public static Ulamek Zero = new(0);
        public static Ulamek One = new(1);
        public static Ulamek Half = new(1, 2);
        public static Ulamek NaN = new();
        public static Ulamek PositiveInfinity = new(1, 0);
        public static Ulamek NegativeInfinity = new(-1, 0);
        #endregion



        public Ulamek(BigInteger l, BigInteger m)
        {
            //Console.WriteLine($"Wprowadzono dane: {l}, {m}");
            var nwd = BigInteger.GreatestCommonDivisor(l, m);
            l /= nwd;
            m /= nwd;
            if (l > 0 && m < 0 || l < 0 && m < 0)
            {
                l *= -1;
                m *= -1;
            }
            Licznik = l;
            Mianownik = m;
            //Console.WriteLine($"Utworzono ulamek: {this}"); 
        }

        public Ulamek(BigInteger n) : this(n, 1) { }


        public override string ToString()
        {
            return $"{Licznik}/{Mianownik}";
        }

        public int CompareTo(Ulamek other)
        {
            // this < other +1
            // this > other -1
            // this == other 0

            return 0;
        }

        public bool Equals(Ulamek other)
        {
            throw new NotImplementedException();
        }

        public static Ulamek operator +(Ulamek a, Ulamek b) => new Ulamek(a.Licznik * b.Mianownik + b.Licznik * a.Mianownik, a.Mianownik * b.Mianownik);
        public static Ulamek operator -(Ulamek a, Ulamek b) => new Ulamek(a.Licznik * b.Mianownik - b.Licznik * a.Mianownik, a.Mianownik * b.Mianownik);
        public static Ulamek operator *(Ulamek a, Ulamek b) => new Ulamek(a.Licznik * b.Licznik, a.Mianownik * b.Mianownik);
        public static Ulamek operator /(Ulamek a, Ulamek b)
        {
            if (b.Licznik == 0) throw new DivideByZeroException();
            return new Ulamek(a.Licznik * b.Mianownik, b.Licznik * a.Mianownik);
        }
    }
}
