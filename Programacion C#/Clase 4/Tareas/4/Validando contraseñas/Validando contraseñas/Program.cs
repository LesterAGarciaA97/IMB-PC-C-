using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validando_contraseñas
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contraseña;
            Console.WriteLine("Bienvenido al sistema de validación de contraseñas");
            Console.ReadLine();

            Console.WriteLine("Ingrese la contraseña del sistema para continuar");
            Contraseña = Convert.ToInt32(Console.ReadLine());

            while (Contraseña != 1111)
            {
                 Console.WriteLine("ERROR. Contraseña incorrecta. Inténtelo de nuevo");
                 Contraseña = Convert.ToInt32(Console.ReadLine());
                if (Contraseña == 1111)
                {
                    Console.WriteLine("Contraseña correcta");
                    Console.WriteLine("Bienvenido");
                    Console.ReadLine();
                }
            }
        }
    }
}
