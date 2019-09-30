using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatuto_If__If_Compuesto_
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double Resultado;

            Console.WriteLine("Multiplicando dos números");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número");
            Num1 = Convert.ToDouble(Console.ReadLine());
            if (Num1 == 0)
            {
                Console.WriteLine("Todo número multiplicado por 0 siempre es 0");
                Console.ReadLine();
            }
            else
                if (Num1 != 0)
            {
                Console.WriteLine("Ingrese un segundo número");
                Num2 = Convert.ToDouble(Console.ReadLine());
                if (Num2 == 0)
                {
                Console.WriteLine("Todo número multiplicado por 0 siempre es 0");
                Console.ReadLine();
                }
                else
                    if (Num2 != 0)
                    {
                        Resultado = Num1 * Num2;
                        Console.WriteLine("El producto de los números ingresado es: " + Resultado);
                        Console.ReadLine();
                    }
            }
        }
    }
}
