using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача___48б
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете х : ");
            double x = double.Parse(Console.ReadLine());

            double y = CalculatingFunction(x);
           
            Console.WriteLine($"y = {y}");
        }

        private static double CalculatingFunction(double x)
        {
            double y = 0;
            if (x <= 0)
            {
                y = x + 2;
            }
            else if (x > 0 && x < 1)
            {
                y = x - 2;
            }
            else if (x >= 1)
            {
                y = 3 * x;
            }

            return y;
        }
    }
}
