using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinar_cual_número_es_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor1;
            double Valor2;
            Console.WriteLine("Determinando el número mayor");
            Console.ReadLine();
            Console.WriteLine("Ingrese un número");
            Valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            Valor2 = Convert.ToDouble(Console.ReadLine());
            if (Valor1 > Valor2)
            Console.WriteLine("El número mayor es " + Valor1);
            Console.ReadLine();
            if (Valor2 > Valor1)
            Console.WriteLine("El número mayor es " + Valor2);
            Console.ReadLine();
        }
    }
}
