using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_Propuesto_1_Estatuto_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Resultado;
            Console.WriteLine("Ingrese un número entero");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Resultado = Num1 % 2;

            //if (Resultado == 0)
            if (Num1 % 2 == 0)
            Console.WriteLine("El número es par");
            Console.ReadLine();
        }
    }

}
