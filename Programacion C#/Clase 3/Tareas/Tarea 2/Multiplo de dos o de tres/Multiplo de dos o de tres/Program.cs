using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo_de_dos_o_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determiando si un número es múltiplo de dos o de tres");
            Console.ReadLine();
            int NumIngresado;
            Console.WriteLine("Ingrese un número entero, no se aceptan decimales");
            NumIngresado = Convert.ToInt32(Console.ReadLine());
            if (NumIngresado % 2 == 0)
            {
            Console.WriteLine("El número es múltiplo de 2");
            Console.ReadLine();
            }
            else if (NumIngresado % 3 == 0)
            {
            Console.WriteLine("El número es múltiplo de 3");
            Console.ReadLine();
            }
        }
    }
}
