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
            ComplexNumbers cN = new ComplexNumbers(0, 2);
            ComplexNumbers cS = new ComplexNumbers(1, 4);

            ComplexNumbers res = cN / cS;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
