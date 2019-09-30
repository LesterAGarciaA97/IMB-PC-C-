using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinar_número_del_1_al_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumPensar;
            Console.WriteLine("¿En cuál número del 1 al 10 estoy pensando?");
            Console.ReadLine();
            Console.WriteLine("Ingrese el número que cree que estoy pensando");
            NumPensar = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
