using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one1
{
    class Program
    {
        static void Main(string[] args)
        {
            float maxfl = float.MaxValue;
            float minfl = float.MinValue;
            Console.Write("The max {0} , The min {1}\n", maxfl, minfl);

            float f = 1f / 3;

            double d = 1d / 3;

            decimal c = 1M / 3;

            Console.WriteLine("\nFloat = {0} \nDouble = {1} \nDecimal = {2} ", f, d, c);
            Console.ReadKey();

        }
    }
}
