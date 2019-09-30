using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinando_si_es_multiplo_o_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            Console.WriteLine("Determinando si un número es múltiplo de otro");
            Console.ReadLine();
            Console.WriteLine("Ingrese un número entero");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número entero");
            Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 % Num2 == 0)
            Console.WriteLine("El número " + Num2 + " es múltiplo de " + Num1);
            Console.ReadLine();
            if (Num1 % Num2 == 1)
            Console.WriteLine("El número " + Num2 + " no es múltiplo de " + Num1);
            Console.ReadLine();
        }
    }
}
