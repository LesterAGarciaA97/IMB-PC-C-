using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_del_100_al_200_divisibles_entre_3_y_7__Ciclo_For_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if ((i % 3 == 0) && (i % 7 == 0))
                {
                    Console.WriteLine(i);
                    Console.ReadLine();
                }
            }
        }
    }
}
