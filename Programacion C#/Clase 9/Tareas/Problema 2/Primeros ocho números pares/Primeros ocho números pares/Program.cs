using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_ocho_números_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros ocho números pares");
            Console.ReadLine();

            for (int i = 2; i < 17; i = i + 2)
            {
                Console.WriteLine(i);
            }
                Console.ReadLine();
        }
    }
}
