using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Número_mayor__Arreglos_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] Numeros = new double[9];

            Console.WriteLine("Ingrese un número");
            Numeros[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            Numeros[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un tercer número");
            Numeros[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un cuarto número");
            Numeros[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un quinto número");
            Numeros[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un sexto número");
            Numeros[5] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un séptimo número");
            Numeros[6] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un último número");
            Numeros[7] = Convert.ToDouble(Console.ReadLine());

            if ((Numeros[0] > Numeros[1]) && (Numeros[0] > Numeros[2]) && (Numeros[0] > Numeros[3]) && (Numeros[0] > Numeros[4]) && (Numeros[0] > Numeros[5]) && (Numeros[0] > Numeros[6]) && (Numeros[0] > Numeros[7]))
            {
                Console.WriteLine("El primer número ingresado 1 es el mayor");
                Console.WriteLine("Se encuentra en la posición 0 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[1] > Numeros[0]) && (Numeros[1] > Numeros[2]) && (Numeros[1] > Numeros[3]) && (Numeros[1] > Numeros[4]) && (Numeros[1] > Numeros[5]) && (Numeros[1] > Numeros[6]) && (Numeros[1] > Numeros[7]))
            {
                Console.WriteLine("El segundo número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 1 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[2] > Numeros[0]) && (Numeros[2] > Numeros[1]) && (Numeros[2] > Numeros[3]) && (Numeros[2] > Numeros[4]) && (Numeros[2] > Numeros[5]) && (Numeros[2] > Numeros[6]) && (Numeros[2] > Numeros[7]))
            {
                Console.WriteLine("El tercer número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 2 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[3] > Numeros[0]) && (Numeros[3] > Numeros[1]) && (Numeros[3] > Numeros[2]) && (Numeros[3] > Numeros[4]) && (Numeros[3] > Numeros[5]) && (Numeros[3] > Numeros[6]) && (Numeros[3] > Numeros[7]))
            {
                Console.WriteLine("El cuarto número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 3 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[4] > Numeros[0]) && (Numeros[4] > Numeros[1]) && (Numeros[4] > Numeros[2]) && (Numeros[4] > Numeros[3]) && (Numeros[4] > Numeros[5]) && (Numeros[4] > Numeros[6]) && (Numeros[4] > Numeros[7]))
            {
                Console.WriteLine("El quinto número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 4 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[5] > Numeros[0]) && (Numeros[5] > Numeros[1]) && (Numeros[5] > Numeros[2]) && (Numeros[5] > Numeros[3]) && (Numeros[5] > Numeros[4]) && (Numeros[5] > Numeros[6]) && (Numeros[5] > Numeros[7]))
            {
                Console.WriteLine("El sexto número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 5 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[6] > Numeros[0]) && (Numeros[6] > Numeros[1]) && (Numeros[6] > Numeros[2]) && (Numeros[6] > Numeros[3]) && (Numeros[6] > Numeros[4]) && (Numeros[6] > Numeros[5]) && (Numeros[6] > Numeros[7]))
            {
                Console.WriteLine("El el séptimo número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 6 del arreglo");
                Console.ReadLine();
            }
            else if ((Numeros[7] > Numeros[0]) && (Numeros[7] > Numeros[1]) && (Numeros[7] > Numeros[2]) && (Numeros[7] > Numeros[3]) && (Numeros[7] > Numeros[4]) && (Numeros[7] > Numeros[5]) && (Numeros[7] > Numeros[6]))
            {
                Console.WriteLine("El octavo número ingresado es el mayor");
                Console.WriteLine("Se encuentra en la posición 7 del arreglo");
                Console.ReadLine();
            }
        }
    }
}
