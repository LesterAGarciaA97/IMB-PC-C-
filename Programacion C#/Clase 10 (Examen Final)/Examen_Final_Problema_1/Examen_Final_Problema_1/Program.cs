using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double Num3;

            Console.WriteLine("Número mayor y número menor");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            Num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un último número");
            Num3 = Convert.ToDouble(Console.ReadLine());

            //Determinar cual de los tres número es el número mayor
            if ((Num1 > Num2) && (Num1 > Num3))
            {
                Console.WriteLine("El número mayor es el número " + Num1);
                Console.ReadLine();
            }
            else if ((Num2 > Num1) && (Num2 > Num3))
            {
                Console.WriteLine("El número mayor es el número " + Num2);
                Console.ReadLine();
            }
            else if ((Num3 > Num1) && (Num3 > Num2))
            {
                Console.WriteLine("El número mayor es el número " + Num3);
            }

            //Determinar cual de los tres números es el número menor
            if ((Num1 < Num2) && (Num1 < Num3))
            {
                Console.WriteLine("El número menor es el número " + Num1);
                Console.ReadLine();
            }
            else if ((Num2 < Num1) && (Num2 < Num3))
            {
                Console.WriteLine("El número menor es el número " + Num2);
                Console.ReadLine();
            }
            else if ((Num3 < Num1) && (Num3 < Num2))
            {
                Console.WriteLine("El número menor es el número " + Num3);
                Console.ReadLine();
            }
        }
    }
}
