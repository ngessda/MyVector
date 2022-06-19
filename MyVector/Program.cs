using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyVectory mv = new MyVectory(5);
            MyVectory mv1 = new MyVectory(5);
            MyVectory ms = mv + mv1;
            Output(ms);
            Console.ReadKey();
        }
        static void Output(MyVectory x)
        {
            for (int i = 0; i < x.lengthVector; i++)
            {
                Console.WriteLine(x[i]);
            }
        }
    }
}
