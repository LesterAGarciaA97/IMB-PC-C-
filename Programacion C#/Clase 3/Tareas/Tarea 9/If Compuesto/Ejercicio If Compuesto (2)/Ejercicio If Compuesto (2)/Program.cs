using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_If_Compuesto__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso compuesto del If
            Console.WriteLine("Ejercicios 2 (If Compuesto)");
            Console.ReadLine();
            int Num1;
            Console.WriteLine("Ingrese un número");
            Num1 = Convert.ToInt32(Console.ReadLine());
            if (Num1 % 2 == 0)
            {
                Console.WriteLine("El número que ingresó es par");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El número que ingresó es impar");
                Console.ReadLine();
            }
        }
    }
}
