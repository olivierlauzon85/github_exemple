using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubc
{
    static class Utilitaire
    {
        public static void WriteTable(int[] Table)
        {
            for (int i = 0; i < Table.Length; ++i)
            {
                Console.WriteLine(Table[i]);
            }
        }
        static Random Generator = new Random();

        public static int GenerateRandomInt(int min, int max)
        {
            return Generator.Next(min, max + 1);
        }

        public static int[] CreateRandomTable(int length, int min, int max)
        {
            int[] randomTable = new int[length];

            for (int cpt = 0; cpt < length; cpt++)
            {
                randomTable[cpt] = GenerateRandomInt(min, max);
            }
            return randomTable;
        }
    }
}
