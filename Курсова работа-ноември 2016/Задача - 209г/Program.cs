using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача___209г
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            RandomNumbers(rnd);
        }

        private static void RandomNumbers(Random rnd)
        {
            Console.WriteLine("Числата са:");
            for (int i = 0; i < 100; i++)
            {

                int number = rnd.Next(0, 132);
                if (number % 7 == 1)
                {
                    Console.WriteLine(number);
                }

            }
        }
    }
}
