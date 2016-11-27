using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача___8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус на основата: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Височина на цилиндъра: ");
            double h = double.Parse(Console.ReadLine());

           
            double B = CalculatingPersonBased(r);
            double S = CalculatingSurfaceArea(r, B, h);
            double V = CalculatingTheVolume(B, h);

            Console.WriteLine($"Лицето на повърхнината е : {S:f2}");
            Console.WriteLine($"Обемът е : {V:f2}");
        }

        private static double CalculatingTheVolume(double b, double h)
        {
            double V = b * h;
            return V;
        }

        private static double CalculatingSurfaceArea(double r, double b, double h)
        {
            double S = 2 * Math.PI * r * h + 2 * b;
            return S;
        }

        private static double CalculatingPersonBased(double r)
        {
            double B = Math.PI* Math.Pow(r, 2);
            return B;
        }
    }
}
