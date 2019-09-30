using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos__Arrays__2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio" };
            Console.WriteLine("Ingresa un número");
            int M = Convert.ToInt32(Console.ReadLine());
            if (M >= 0 && M <= 6)
            {
                Console.WriteLine("El mes " + M + " es " + Mes[M]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No es un mes del año");
                Console.ReadLine();
            }
        }
    }
}
