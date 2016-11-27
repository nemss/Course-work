using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача___372з
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Въведете брой градове: ");
            int n = int.Parse(Console.ReadLine());

            string[] towns = new string[n];
            int maxLenghtTown = 0;

            maxLenghtTown = Input(n, towns, maxLenghtTown);

            OutputTowns(towns, maxLenghtTown);
        }

        private static int Input(int n, string[] towns, int maxLenghtTown)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете града с главна буква: ");
                string stringTowns = Console.ReadLine();

                if (!IsUpper(stringTowns.Substring(0, 1)))
                {
                    Console.WriteLine("Градът започва с малка буква.");
                    i--;
                }
                else
                {
                    maxLenghtTown = InputTowns(towns, maxLenghtTown, i, stringTowns);
                }
            }

            return maxLenghtTown;
        }

        //Този метод вкарва градовете, които са с главна буква в масива и проверява дали тяхната дължина е по могяма от максималната.
        private static int InputTowns(string[] towns, int maxLenghtTown, int i, string stringTowns)
        {
            towns[i] = stringTowns;
            if (towns[i].Length > maxLenghtTown)
            {
                maxLenghtTown = towns[i].Length;
            }

            return maxLenghtTown;
        }
        static void OutputTowns(string[] towns, int maxLenghtTown)
        {
            Console.WriteLine("Градът/овете с най - голяма дължина е/са: ");

            for (int i = 0; i < towns.Length; i++)
            {
                if (towns[i].Length == maxLenghtTown)
                {
                    Console.WriteLine("град {0}", towns[i]);
                }

            }
        }
        public static bool IsUpper(string firstLetterTown) //Този метод проверява дали градовете са с главна буква.
        {

            for (int i = 0; i < firstLetterTown.Length; i++)
            {
                if (char.IsLower(firstLetterTown[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

