using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Final_Parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dua1; //Intervalos entre 1 - 500
            int Dua2; //Intervalos entre 501 - 1200
            int Dua3; //Intervalos entre 1201 - 3000
            double NumIngresado;

            Console.WriteLine("Bienvenido al sistema de asignación de DUAS");
            Console.ReadLine();

            Console.Write("Ingrese un número para poder asignarle una DUA ");
            NumIngresado = Convert.ToDouble(Console.ReadLine());

            if (NumIngresado < 0)
            {
                Console.WriteLine("ERROR, DUA no registrada. Inténtelo de nuevo");
                Console.ReadLine();
            }
            else if ((NumIngresado > 0) && (NumIngresado <= 500))
            {
                Console.WriteLine("Su número se encuentra en el intervalo de 1 a 500");
                Console.WriteLine("Se le ha asignado la DUA1");
                Console.ReadLine();
            }
            else if ((NumIngresado >= 501) && (NumIngresado <= 1200))
            {
                Console.WriteLine("Su número se encuentra en el intervalo de 501 a 1200");
                Console.WriteLine("Se le ha asignado la DUA2");
                Console.ReadLine();
            }
            else if ((NumIngresado >= 1201) && (NumIngresado <= 3000))
            {
                Console.WriteLine("Su número se encuentra en el intervalo de 1201 a 3000");
                Console.WriteLine("Se le ha asignado la DUA3");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Su número está fuera del rango de DUAS registradas");
                Console.WriteLine("Ingrese un número de DUA válido y registrado");
                Console.ReadLine();
            }

            Console.WriteLine("Gracias por utilizar el servicio de asignacion de DUAS");
            Console.ReadLine();
        }
    }
}
