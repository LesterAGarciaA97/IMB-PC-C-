using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escribiendo_el_número_ingresado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribiendo el nombre completo de un número");
            Console.ReadLine();
            int NumIngresado;
            Console.WriteLine("Ingrese un número entero");
            NumIngresado = Convert.ToInt32(Console.ReadLine());

            switch (NumIngresado)
            {
                case 1:
                    Console.WriteLine("Uno");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
