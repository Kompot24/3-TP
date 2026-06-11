using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Fraction
    {
        private double denominator;
        private double numerator;
        
        public static Fraction operator+(Fraction fract, Fraction fraction)
        {
            if (fract.denominator == fraction.denominator)
            {
                fract.numerator = fract.numerator + fraction.numerator;
                return fract;
            }
            else
            {
                fract.numerator = fract.numerator * fraction.denominator;
                fraction.numerator = fraction.numerator * fract.denominator;
                fract.numerator = fract.numerator + fraction.numerator;
                fract.denominator = fract.denominator * fraction.denominator;
                return fract;
            }
        }

        public static Fraction operator-(Fraction fract, Fraction fraction)
        {
            if(fract.denominator == fraction.denominator)
            {
                fract.numerator = fract.numerator - fraction.numerator;
                return fract;
            }
            else
            {
                fract.numerator = fract.numerator * fraction.denominator;
                fraction.numerator = fraction.numerator * fract.denominator;
                fract.numerator = fract.numerator - fraction.numerator;
                fract.denominator = fract.denominator * fraction.denominator;
                return fract;
            }
        }

        public static Fraction operator*(Fraction fract, Fraction fraction)
        {
            fract.numerator *= fraction.numerator;
            fract.denominator *= fraction.denominator;
            return fract;
        }

        
        public static Fraction operator/(Fraction fract, Fraction fraction)
        {
            fract.numerator *= fraction.denominator;
            fract.denominator *= fraction.numerator;
            return fract;
        }

        public Fraction Reduction(Fraction fract)
        {
            double largest;
            if (fract.numerator > fract.denominator)
            {
                largest = fract.numerator;
            }
            else
            {
                largest = fract.denominator;
            }
            for (double i = largest; i >= 2; i--)
            {
                if (fract.numerator % i == 0 && fract.denominator % i == 0)
                {
                    fract.numerator /= i;
                    fract.denominator /= i;
                    return fract;
                }
            }
            return fract;
        }

        public static Fraction operator >(Fraction fract, Fraction fraction)
        {
            double num1 = fract.numerator / fract.denominator;
            double num2 = fraction.numerator / fraction.denominator;

            if (num1 > num2)
            {
                return fract;
            }
            else
            {
                return fraction;
            }
        }

        public static Fraction operator <(Fraction fract, Fraction fraction)
        {
            double num1 = fract.numerator / fract.denominator;
            double num2 = fraction.numerator / fraction.denominator;

            if (num1 < num2)
            {
                return fract;
            }
            else
            {
                return fraction;
            }
        }

        public Fraction(double numerator, double denominator) {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public string Verbose()
        {
            if(denominator == 1)
            {
                return $"Дробь:{numerator}";
            }
            else
            {
                return $"Дробь:{numerator}/{denominator}";
            }
        }
    }
}
