using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    public class MyVectory
    {
        public double[] a;
        private int length;
        public int lengthVector
        {
            get { return length; }
        }

        public MyVectory()
        {
            a = new double[0];
        }

        public MyVectory(int length)
        {
            this.length = length;
            CreateRandom(length);
        }
        public MyVectory(double[] z)
        {
            length = z.Length;
            a = z;
        }
        public MyVectory this [int index]
        {
            get
            {
                return this[index];
            }
        }

        private double[] CreateRandom(int length)
        {
            Random random = new Random();
            a = new double[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = random.NextDouble();
            }
            return a;
        }

        public static int[] Arrange(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = i;
            }
            return a;
        }
        public static int[] Zeros(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = 0;
            }
            return a;
        }
        public static int[] Ones(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = 1;
            }
            return a;
        }
        public double Norm()
        {
            double res = 0;
            for (int i = 0; i < length; i++)
            {
                res += Math.Pow(a[i], 2);
            }
            return Math.Sqrt(res);
        }

        public static MyVectory operator +(MyVectory a, MyVectory b)
        {
            MyVectory vs = a;
            for (int i = 0; i < a.length; i++)
            {
                vs.a[i] += b.a[i];
            }
            return vs;
        }
        
        public static MyVectory operator -(MyVectory a, MyVectory b)
        {
            MyVectory vs = a;
            for (int i = 0; i < a.length; i++)
            {
                vs.a[i] -= b.a[i];
            }
            return vs;
        }

        public static MyVectory operator *(MyVectory a, double b)
        {
            MyVectory vs = a;
            for (int i = 0; i < a.length; i++)
            {
                vs.a[i] *= b;
            }
            return vs;
        }

        public static MyVectory operator *(double b, MyVectory a)
        {
            MyVectory vs = a;
            for (int i = 0; i < a.length; i++)
            {
                vs.a[i] *= b;
            }
            return vs;
        }
        public double ScalarTimes(MyVectory b)
        {
            if(a.Length != b.length)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                double result = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    result += a[i] * b.a[i];
                }
                return result;
            }
        }

        public static double ScalarTimes(MyVectory a, MyVectory b)
        {
            if(a.length != b.length)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                double result = 0;
                for (int i = 0; i < a.length; i++)
                {
                    result += a.a[i] * b.a[i];
                }
                return result;
            }
        }
    }
}
