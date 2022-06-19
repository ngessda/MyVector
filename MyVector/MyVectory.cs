using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    public class MyVectory
    {
        private double[] a;
        public int lengthVector
        {
            get { return a.Length; }
        }

        public MyVectory()
        {
            a = new double[0];
        }

        public MyVectory(int length)
        {
            Random random = new Random();
            a = new double[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = random.NextDouble();
            }
        }
        public MyVectory(double[] z)
        {
            a = new double[z.Length];
            a = (double[])z.Clone();
        }
        public double this [int index]
        {
            get
            {
                return a[index];
            }
        }

        public static MyVectory Arrange(int n)
        {
            MyVectory z = new MyVectory(n);
            for (int i = 0; i < n; i++)
            {
                z.a[i] = i;
            }
            return z;
        }
        public static MyVectory Zeros(int n)
        {
            MyVectory z = new MyVectory(n);
            for (int i = 0; i < n; i++)
            {
                z.a[i] = 0;
            }
            return z;
        }
        public static MyVectory Ones(int n)
        {
            MyVectory z = new MyVectory(n);
            for (int i = 0; i < n; i++)
            {
                z.a[i] = 1;
            }
            return z;
        }
        public double Norm()
        {
            double res = 0;
            for (int i = 0; i < lengthVector; i++)
            {
                res += Math.Pow(a[i], 2);
            }
            return Math.Sqrt(res);
        }

        public static MyVectory operator +(MyVectory a, MyVectory b)
        {
            if (a.lengthVector != b.lengthVector)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                MyVectory vs = new MyVectory(a.lengthVector);
                for (int i = 0; i < a.lengthVector; i++)
                {
                    vs.a[i] = a.a[i] + b.a[i];
                }
                return vs;
            }
        }
        
        public static MyVectory operator -(MyVectory a, MyVectory b)
        {
            if (a.lengthVector != b.lengthVector)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                MyVectory vs = new MyVectory(a.lengthVector);
                for (int i = 0; i < a.lengthVector; i++)
                {
                    vs.a[i] = a.a[i] - b.a[i];
                }
                return vs;
            }
        }

        public static MyVectory operator *(MyVectory a, double b)
        {
            MyVectory vs = new MyVectory(a.lengthVector);
            for (int i = 0; i < a.lengthVector; i++)
            {
                vs.a[i] = a.a[i] * b;
            }
            return vs;
        }

        public static MyVectory operator *(double b, MyVectory a)
        {
            MyVectory vs = new MyVectory(a.lengthVector);
            for (int i = 0; i < a.lengthVector; i++)
            {
                vs.a[i] = a.a[i] * b;
            }
            return vs;
        }
        public double ScalarTimes(MyVectory b)
        {
            if(a.Length != b.lengthVector)
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
            if(a.lengthVector != b.lengthVector)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                double result = 0;
                for (int i = 0; i < a.lengthVector; i++)
                {
                    result += a.a[i] * b.a[i];
                }
                return result;
            }
        }
        
        public double Distance(MyVectory b)
        {
            if (a.Length != b.lengthVector)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                double res = 0;
                for (int i = 0; i < b.lengthVector; i++)
                {
                    res += Math.Pow(a[i] - b.a[i], 2);
                }
                return Math.Sqrt(res);
            }
        }
        public static double Distance(MyVectory a, MyVectory b)
        {
            if (a.lengthVector != b.lengthVector)
            {
                throw new ArgumentException("Ты совсем даун?");
            }
            else
            {
                double res = 0;
                for (int i = 0; i < b.lengthVector; i++)
                {
                    res += Math.Pow(a.a[i] - b.a[i], 2);
                }
                return Math.Sqrt(res);
            }
        }
    }
}
