using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividiendo_dos_números
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diviendo dos números");
            Console.ReadLine();
            double Num1;
            double Num2;
            Console.Write("Ingrese un número ");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese un segundo número ");
            Num2 = Convert.ToDouble(Console.ReadLine());
            if (Num2 == 0)
            {
            Console.WriteLine("ERROR, No se puede dividir un número entre 0");
            Console.ReadLine();
            }
            else
            {
            double Resultado;
            Resultado = (Num1 / Num2);
            Console.WriteLine("El resultado de la division es " + Resultado);
            Console.ReadLine();
            }
        }
    }
}
