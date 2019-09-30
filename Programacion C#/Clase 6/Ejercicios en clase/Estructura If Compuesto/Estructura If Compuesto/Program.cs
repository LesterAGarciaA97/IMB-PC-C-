using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_If_Compuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumIngresado;

            Console.WriteLine("Días de la semana");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número entero positivo entre 1 y 7");
            NumIngresado = Convert.ToInt32(Console.ReadLine());

            if (NumIngresado == 1)
            {
                Console.WriteLine("Lunes");
                Console.ReadLine();
            }
            else if (NumIngresado == 2)
            {
                Console.WriteLine("Martes");
                Console.ReadLine();
            }
            else if (NumIngresado == 3)
            {
                Console.WriteLine("Miércoles");
                Console.ReadLine();
            }
            else if (NumIngresado == 4)
            {
                Console.WriteLine("Jueves");
                Console.ReadLine();
            }
            else if (NumIngresado == 5)
            {
                Console.WriteLine("Viernes");
                Console.ReadLine();
            }
            else if (NumIngresado == 6)
            {
                Console.WriteLine("Sábado");
                Console.ReadLine();
            }
            else if (NumIngresado == 7)
            {
                Console.WriteLine("Domingo");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR, Ingrese un número válido para el sistema");
                Console.ReadLine();
            }
        }
    }
}
