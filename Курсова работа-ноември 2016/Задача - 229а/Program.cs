using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача___229а
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInputTitle('k');
            int k = int.Parse(Console.ReadLine());
            int[] arrayK = new int[k];

            ArrayInitialization(arrayK);
            int sumK = Sum(arrayK);
            Console.WriteLine($"Сумата от елементите на масивa е: {sumK}");

            PrintInputTitle('m');
            int m = int.Parse(Console.ReadLine());
            int[] arrayM = new int[m];

            ArrayInitialization(arrayM);
            int sumM = Sum(arrayM);
            Console.WriteLine($"Сумата от елементите на масива е: {sumM}");

            PrintInputTitle('n');
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];

            ArrayInitialization(arrayN);
            int sumN = Sum(arrayN);
            Console.WriteLine($"Сумата от елементите на масива е: {sumN}");

            Console.WriteLine(new string('-', 50));

            double averageArrays = (sumK + sumM + sumN) / 3;
            Console.WriteLine($"Средната стойност на масивите е: {averageArrays}");

        }

       

        

        private static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
         }

        private static void ArrayInitialization(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void PrintInputTitle(char element)
        {
            Console.Write($"Въведете брой елементи на {element}: ");
        }


    }
}
