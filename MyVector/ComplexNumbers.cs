using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    //Перегруза +,-,*,/, ToString
    public class ComplexNumbers
    {
        private const double EPS = 0.0000000000001;
        private double re;
        private double im;

        public ComplexNumbers()
        {
            re = 0;
            im = 0;
        }

        public ComplexNumbers(double r, double i)
        {
            re = r;
            im = i;
        }

        public static ComplexNumbers operator +(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers c = new ComplexNumbers();
            c.re = a.re + b.re;
            c.im = a.im + b.im;
            return c;
        }

        public static ComplexNumbers operator -(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers c = new ComplexNumbers();
            c.re = a.re - b.re;
            c.im = a.im - b.im;
            return c;
        }

        public static ComplexNumbers operator *(ComplexNumbers a, ComplexNumbers b)
        {
            ComplexNumbers c = new ComplexNumbers();
            c.re = (a.re * b.re) - (a.im * b.im);
            c.im = (a.re * b.im) + (a.im * b.re);
            return c;
        }
        public static ComplexNumbers operator /(ComplexNumbers a, ComplexNumbers b)
        {
            try
            {
                if (a.re == 0 && a.im == 0 || b.re == 0 && b.im == 0)
                {
                    throw new ArgumentException();
                }
            }
            catch(ArgumentException) 
            {
                Console.WriteLine("Еблан?");
                return null;
            }
            ComplexNumbers c = new ComplexNumbers();
            c.re = ((a.re * b.re) + (a.im * b.im)) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2));
            c.im = ((a.im * b.re) - (a.re * b.im)) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2));
            return c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Math.Abs(re) >= EPS)
            {
                if (Math.Abs(im) > EPS)
                {
                    sb.Append($"{re} + i * {im}");
                }
                else if (Math.Abs(im) < EPS)
                {
                    sb.Append($"{re} - i * {-im}");
                }
            }
            else if (Math.Abs(re) < EPS)
            {
                if (Math.Abs(im) > EPS)
                {
                    sb.Append($" i * {im}");
                }
                else if (Math.Abs(im) < EPS)
                {
                    sb.Append($"- i * {-im}");
                }
            }
            return sb.ToString();
        }
    }
}
