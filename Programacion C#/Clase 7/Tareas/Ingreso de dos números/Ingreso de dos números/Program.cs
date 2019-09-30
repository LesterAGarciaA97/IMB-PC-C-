using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_de_dos_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Salir = 1000;

            Console.WriteLine("Números múltiplos de otros números");
            Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese un número entero positivo");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un segundo número entero positivo");
                Num2 = Convert.ToInt32(Console.ReadLine());

                if (Num1 % Num2 == 0)
                {
                    Console.WriteLine("El segundo número ingresado es múltiplo del primer número");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El segundo número ingresado no es múltiplo del primer número");
                    Console.ReadLine();
                }  
            }
            while ((Num1 < Salir) && (Num2 < Salir));
        }
    }
}
