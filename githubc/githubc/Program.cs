using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubc
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[24];
            table =Utilitaire.CreateRandomTable(table.Length, 0, 100);
            Utilitaire.WriteTable(table);
        }
    }
}
