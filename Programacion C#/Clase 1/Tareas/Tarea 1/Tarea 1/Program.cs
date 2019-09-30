using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            double Respuesta1;
            Num1 = 2;
            Respuesta1 = Math.Pow(Num1, 3);
            Console.WriteLine("El resultado de elevar al cubo el número 2 es: {0}", Respuesta1);
            Console.ReadLine();
            Console.WriteLine(Respuesta1);
            Console.ReadLine();

            double Num2;
            double Respuesta2;
            Num2 = 3;
            Respuesta2 = Math.Pow(Num2, 3);
            Console.WriteLine("El resultado de elevar al cubo el número 3 es: ");
            Console.ReadLine();
            Console.WriteLine(Respuesta2);
            Console.ReadLine();

            double Num3;
            double Respuesta3;
            Num3 = 4;
            Respuesta3 = Math.Pow(Num3, 3);
            Console.WriteLine("El resultado de elevar al cubo el número 4 es: ");
            Console.ReadLine();
            Console.WriteLine(Respuesta3);
            Console.ReadLine();
        }
    }
}
