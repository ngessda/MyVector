using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    public class MyVectory
    {
        public double a;
        public double b;
        public double lengthVector;

        public MyVectory(double a, double b)
        {
            this.a = a;
            this.b = b;
            lengthVector = LengthVectory();
        }

        private double LengthVectory()
        {
            double lengthVectory = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return lengthVectory;
        }

        public static MyVectory operator +(MyVectory a, MyVectory b)
        {
            MyVectory vs = new MyVectory(a.a + b.a, a.b + b.b);
            return vs;
        }
        
        public static MyVectory operator -(MyVectory a, MyVectory b)
        {
            MyVectory vs = new MyVectory(a.a - b.a, a.b - b.b);
            return vs;
        }

        public static MyVectory operator *(MyVectory a, double b)
        {
            MyVectory vs = new MyVectory(a.a * b, a.b * b);
            return vs;
        }

        public static MyVectory operator *(double b, MyVectory a)
        {
            MyVectory vs = new MyVectory(a.a * b, a.b * b);
            return vs;
        }

        public double ScaleMultiplyVectory(MyVectory a, MyVectory b)
        {
            double vs = a.a * b.a + a.b * b.b;
            return vs;
        }
    }
}
