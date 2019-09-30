using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_tres_números
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double Num3;
            double Resultado;
            Console.WriteLine("La suma de tres números ingresados por el usuario");
            Console.ReadLine();
            Console.Write("Ingrese un número: ");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese un segundo número: ");
            Num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese un tercer número: ");
            Num3 = Convert.ToDouble(Console.ReadLine());
            Resultado = Convert.ToDouble(Num1 + Num2 + Num3);
            Console.Write("El resultado de la suma de los tres números es: " + Resultado);
            Console.ReadLine();
        }
    }
}
