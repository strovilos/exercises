using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFraction
{
    class Fraction : IComparable
    {
        // field
        private int _f2;
        private decimal _value;

        // prop.
        int F1 { get; set; } // numerator
        int F2 // denominator != 0
        {
            get { return _f2; }
            set
            {
                //if (_f2 == 0) return;
                //else
                _f2 = value;
            }
        }
        public decimal Value { get { return _value; } private set { _value = value; } }

        // constructors :
        // default 
        public Fraction() 
        {
            F1 = 0;
            F2 = 1;
            Value = 0;
        }

        public Fraction(int f1, int f2)
        {
            F1 = f1;
            F2 = f2;
            Value = (decimal)F1 / (decimal)F2;
        }

        // int to fraction
        public Fraction(int f1)
        {
            F1 = f1;
            F2 = 1;
            Value = (decimal)F1;
        }

        // methods:
        // Override ToString() to print the fraction
        public override string ToString()
        {
            string print = "";
            if (F1 * F2 < 0) // negative fraction
                print = "-";
            print += Math.Abs(F1) + "/" + Math.Abs(F2);

            //print = "Fraction: " + F1 + "/" + F2;
            //Console.WriteLine(print);
            return print;
        }

        // create a fraction from a string
        public static Fraction Parse(string str)
        {
            string[] fr = str.Split('/');
            if (fr.Length != 2)
                throw new ArgumentException("String must be of format x/y.");
            //int f1 = int.Parse(fr[0]);
            //int f2 = int.Parse(fr[1]);
            bool b1 = int.TryParse(fr[0], out int f1);
            bool b2 = int.TryParse(fr[1], out int f2);

            return new Fraction(f1, f2);
        }

        // overloading operator *
        // fraction * fraction
        public static Fraction operator *(Fraction Fraction1, Fraction Fraction2)
        {
            int a = Fraction1.F1 * Fraction2.F1;
            int b = Fraction1.F2 * Fraction2.F2;
            return new Fraction(a, b);
        }

        // fraction * int
        public static Fraction operator *(Fraction Fraction, int i)
        {
            return Fraction * new Fraction(i);
        }

        // int * fraction
        public static Fraction operator *(int i, Fraction Fraction)
        {
            return new Fraction(i) * Fraction;
        }

        // implement method of IComparable
        public int CompareTo(object obj)
        {
            Fraction F = obj as Fraction;

            if (this.Value > F.Value)
                return 1;
            else if (this.Value == F.Value)
                return 0;
            else
                return -1;
            //throw new NotImplementedException();
        }

    }
}
