using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estatuto_If__If_Compuesto____2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Resultado;
            Console.WriteLine("Dividiendo dos números");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            Num2 = Convert.ToInt32(Console.ReadLine());

            /*if ((Num1 % 2 != 0) || (Num2 % 2 != 0))
            {
                Console.WriteLine("Ingrese un número entero, no se admiten decimales");
                Console.ReadLine();
            }*/
            
            if (Num2 == 0)
            {
            Console.WriteLine("ERROR: No se puede dividir ningun número entre 0");
            Console.ReadLine();
            }
            else if (Num2 != 0)
            {
            Resultado = (Num1 / Num2);
            Console.WriteLine("El resultado de la division de los dos números ingresados es " + Resultado);
            Console.ReadLine();
            }
        }
    }
}
