using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* https://github.com/AFDEmp/CSharp/blob/master/CB4_MMa18/Exercises/Exercises.md
Exercise Fraction
    Define a class Fraction, which contains information about the rational fraction(e.g. 1/4).
    Define the appropriate fields, properties and constructors.
    Override ToString() to print the Fraction (e.g. "1/4").
    Override operator * to multiply two Fractions.
    Define a static method Parse(string str) to create a Fraction from a string.
    Define a property of type decimal to return the decimal value of the fraction(e.g. 0.25).
    Implement IComparable interface to enable sorting of Fractions.
    Write a function Cancel() to cancel the Fraction. (e.g. 10/15 is cancelled to 2/3).
    Test implemented functionality in Main().
*/

namespace ExerciseFraction
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter a fraction (e.g. 11/45): ");
            string s1 = Console.ReadLine();
            Fraction Fraction1 = new Fraction();
            //Fraction Fraction1;
            try
            {
                
                Fraction1 = Fraction.Parse(s1);
                //Fraction1.ToString();
                Console.WriteLine(Fraction1);
                Console.WriteLine(Fraction1.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Please enter another fraction (e.g. 11/45): ");
            string s2 = Console.ReadLine();
            Fraction Fraction2 = Fraction.Parse(s2);
            //Fraction Fraction2 = new Fraction();
            //Fraction2 = Fraction.Parse(s2);
            //Fraction2.ToString();
            Console.WriteLine(Fraction2);
            Console.WriteLine(Fraction2.Value);

            // mutliply fractions
            Console.Write("Result of multiplication = ");
            Fraction FractionM = new Fraction();
            FractionM = Fraction1 * Fraction2;
            //FractionM.ToString();
            Console.WriteLine(FractionM);
            Console.WriteLine(FractionM.Value);

            Console.Write("Please press any key to exit...");
            Console.ReadKey();
        }
    }
}
