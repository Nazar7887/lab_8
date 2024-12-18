using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменник не може бути нулем.");
            }
            Numerator = numerator;
            Denominator = denominator;
            Reduce();
        }

        public Fraction(Fraction other)
        {
            Numerator = other.Numerator;
            Denominator = other.Denominator;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }


        public static Fraction operator +(Fraction f)
        {
            return f;
        }

        public static Fraction operator -(Fraction f)
        {
            return new Fraction(-f.Numerator, f.Denominator);
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numerator = f1.Numerator * f2.Numerator;
            int denominator = f1.Denominator * f2.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f2.Numerator == 0)
            {
                throw new DivideByZeroException("Ділення на нуль.");
            }
            int numerator = f1.Numerator * f2.Denominator;
            int denominator = f1.Denominator * f2.Numerator;
            return new Fraction(numerator, denominator);
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1.ToDouble() > f2.ToDouble();
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1.ToDouble() < f2.ToDouble();
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1.ToDouble() == f2.ToDouble();
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return f1.ToDouble() != f2.ToDouble();
        }

        private void Reduce()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
