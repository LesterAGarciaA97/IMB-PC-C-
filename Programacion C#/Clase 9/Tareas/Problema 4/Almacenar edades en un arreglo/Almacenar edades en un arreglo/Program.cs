using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenar_edades_en_un_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] IngresoEdades = new int[7];

            Console.WriteLine("Ingrese su edad");
            IngresoEdades[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            IngresoEdades[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            IngresoEdades[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            IngresoEdades[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            IngresoEdades[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            IngresoEdades[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su edad");
            IngresoEdades[6] = Convert.ToInt32(Console.ReadLine());

            if (IngresoEdades[0] > 18)
            {
                Console.WriteLine("El usuario 1 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 1 es menor de edad");
                Console.ReadLine();
            }
            if (IngresoEdades[1] > 18)
            {
                Console.WriteLine("El usuario 2 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 2 es menor de edad");
                Console.ReadLine();
            }
            if (IngresoEdades[2] > 18)
            {
                Console.WriteLine("El usuario 3 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 3 es menor de edad");
                Console.ReadLine();
            }
            if (IngresoEdades[3] > 18)
            {
                Console.WriteLine("El usuario 4 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 4 es menor de edad");
                Console.ReadLine();
            }
            if (IngresoEdades[4] > 18)
            {
                Console.WriteLine("El usuario 5 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 5 es menor de edad");
                Console.ReadLine();
            }
            if (IngresoEdades[5] > 18)
            {
                Console.WriteLine("El usuario 6 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 6 es menor de edad");
                Console.ReadLine();
            }
            if (IngresoEdades[6] > 18)
            {
                Console.WriteLine("El usuario 7 es mayor de edad");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El usuario 7 es menor de edad");
                Console.ReadLine();
            }
        }
    }
}
