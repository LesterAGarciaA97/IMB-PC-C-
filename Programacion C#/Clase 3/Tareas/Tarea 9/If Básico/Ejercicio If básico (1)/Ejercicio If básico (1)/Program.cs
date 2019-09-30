using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_If_básico__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso básico del estatuto If
            Console.WriteLine("Ejercicio 1 (If básico)");
            Console.ReadLine();
            int Num1;
            Console.WriteLine("Ingrese un número");
            Num1 = Convert.ToInt32(Console.ReadLine());
            if (Num1 % 2 == 0)
            {
                Console.WriteLine("El número que ingresó es un número par");
                Console.ReadLine();
            }
        }
    }
}
