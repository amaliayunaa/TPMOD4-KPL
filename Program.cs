using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL4_1302204100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama User: ");

        }

        class HaloGeneric
        {
            public static void SapaUser <R> (R nama)
            {
                Console.WriteLine("Halo User" + nama);
            }
        }

    }
}
