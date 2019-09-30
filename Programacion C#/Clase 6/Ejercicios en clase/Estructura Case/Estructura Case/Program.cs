using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumIngresado;

            Console.WriteLine("Días de la semana");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número entero del 1 al 7");
            NumIngresado = Convert.ToInt32(Console.ReadLine());

            switch (NumIngresado)
            { 
                case 1:
                    Console.WriteLine("Lunes");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("ERROR, Ingrese un número válido para el sistema");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
