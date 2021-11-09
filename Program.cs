using System;

namespace OOP_HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new RationalNumbers(175, 2);
            var r2 = new RationalNumbers(3, 4);
            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r1 + r2);
            Console.WriteLine(r1 - r2);
            Console.WriteLine(r1 * r2);
            Console.WriteLine(r1 / r2);
            Console.WriteLine(++r1);
            Console.WriteLine(--r1);
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r1 != r2);
            Console.WriteLine(r1 >= r2);
            Console.ReadKey();
        }

        public class RationalNumbers
        {
            private int numerator { get; set; }
            private int denominator { get; set; }

            public RationalNumbers(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            public static RationalNumbers operator +(RationalNumbers a, RationalNumbers b) => new(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
            public static RationalNumbers operator -(RationalNumbers a, RationalNumbers b) => new(a.numerator * b.denominator - b.numerator * a.denominator, a.denominator * b.denominator);
            public static RationalNumbers operator ++(RationalNumbers a) => new(a.numerator + a.denominator, a.denominator);
            public static RationalNumbers operator --(RationalNumbers a) => new(a.numerator - a.denominator, a.denominator);
            public static bool operator ==(RationalNumbers a, RationalNumbers b) => a.numerator / a.denominator == b.numerator / b.denominator;
            public static bool operator !=(RationalNumbers a, RationalNumbers b) => a.numerator / a.denominator != b.numerator / b.denominator;
            public static bool operator >(RationalNumbers a, RationalNumbers b) => a.numerator / a.denominator > b.numerator / b.denominator;
            public static bool operator >=(RationalNumbers a, RationalNumbers b) => a.numerator / a.denominator >= b.numerator / b.denominator;
            public static bool operator <(RationalNumbers a, RationalNumbers b) => a.numerator / a.denominator < b.numerator / b.denominator;
            public static bool operator <=(RationalNumbers a, RationalNumbers b) => a.numerator / a.denominator <= b.numerator / b.denominator;
            public static RationalNumbers operator *(RationalNumbers a, RationalNumbers b) => new(a.numerator * b.numerator, a.denominator * b.denominator);
            public static RationalNumbers operator /(RationalNumbers a, RationalNumbers b) => new(a.numerator * b.denominator, a.denominator * b.numerator);
            //public static RationalNumbers operator %(RationalNumbers a, RationalNumbers b) => new((a.numerator * b.denominator) - Math.Floor(((a.numerator * b.denominator) / (a.denominator * b.numerator))), a.denominator * b.numerator);

            public static explicit operator float(RationalNumbers a) => (float)a.numerator / a.denominator;

            public static explicit operator int(RationalNumbers a) => (int)a.numerator / a.denominator;
            public override string ToString() => $"{numerator}/{denominator}";
        }


    }
}
