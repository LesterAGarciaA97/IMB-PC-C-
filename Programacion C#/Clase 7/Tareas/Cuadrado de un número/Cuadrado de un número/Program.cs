using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado_de_un_número
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumIngresado;

            Console.WriteLine("Calculadora de cuadrados de números diferentes a 0");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número entero");
            NumIngresado = Convert.ToInt32(Console.ReadLine());

            while ((NumIngresado != 0) && (NumIngresado > 0))
            {
                Console.WriteLine("El cuadrado del número ingresado es: " + Math.Pow(NumIngresado,2));
                Console.ReadLine();
                Console.WriteLine("Ingrese un número entero");
                NumIngresado = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
