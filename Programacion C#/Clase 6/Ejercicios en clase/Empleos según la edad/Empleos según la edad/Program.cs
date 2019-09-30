using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleos_según_la_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edad;

            Console.WriteLine("Bienvenido al sistema automático de empleos");
            Console.ReadLine();

            Console.WriteLine("Ingrese su nombre completo");
            Console.ReadLine();
            Console.WriteLine("Ingrese su edad actual");
            Edad = Convert.ToInt32(Console.ReadLine());

           // while ((Edad != 25) && (Edad != 26) && (Edad != 27) && (Edad != 28) && (Edad != 29) && (Edad != 30) && (Edad != 31) && (Edad != 32) && (Edad != 33) && (Edad != 34) && (Edad != 35))
            while ((Edad < 25) || (Edad > 35))
            {
                Console.WriteLine("Se han ingresado sus datos correctamente");
                Console.WriteLine("Se le estará notificando en unos días vía telefónica la decisión final");
                Console.WriteLine("Gracias por utilizar el servicio automático de empleos");
                Console.ReadLine();
                Console.WriteLine("Ingrese su nombre completo");
                Console.ReadLine();
                Console.WriteLine("Ingrese su edad actual");
                Edad = Convert.ToInt32(Console.ReadLine());

                //if ((Edad == 25) || (Edad == 26) || (Edad == 27) || (Edad == 28) || (Edad == 29) || (Edad == 30) || (Edad == 31) || (Edad == 32) || (Edad == 33) || (Edad == 34) || (Edad == 35))
                if ((Edad >= 25) && (Edad <= 35))
                {
                    Console.WriteLine("Se han ingresado sus datos correctamente");
                    Console.WriteLine("Usted puede aplicar a la plaza de programador");
                    Console.WriteLine("Pase a la siguiente sala para realizar unas pruebas específicas");
                    Console.ReadLine();
                }
            }
        }
    }
}
