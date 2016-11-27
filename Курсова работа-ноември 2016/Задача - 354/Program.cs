using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача___354
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            ConversionToUppercase(text);
        }

        private static void ConversionToUppercase(string text)
        {
            Console.WriteLine(text.ToUpper());
        }
    }
}
