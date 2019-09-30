using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double Division;

            Console.WriteLine("Divisón entre dos números");
            Console.ReadLine();

            Console.WriteLine("Ingrese un número");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            Num2 = Convert.ToDouble(Console.ReadLine());

            Division = Num1 / Num2;

            if (Num2 != 0)
            {
                Console.WriteLine("El resultado de la división es: " + Division);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR");
                Console.WriteLine("La divisón de cualquier número entre 0 no se puede realizar");
                Console.ReadLine();
            }
        }
    }
}
