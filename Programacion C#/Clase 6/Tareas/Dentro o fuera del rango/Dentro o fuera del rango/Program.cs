using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentro_o_fuera_del_rango
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;

            Console.WriteLine("Bienvenido al sistema de validación de correlativos");
            Console.ReadLine();

            do
            {
                Console.WriteLine("Ingrese un número incial de rango");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un número final de rango");
                Num2 = Convert.ToInt32(Console.ReadLine());

                 if ((Num1 >= 1) && (Num2 <= 1000))
                {
                    Console.WriteLine("Los números que usted ingresó están dentro del correlativo base");
                    Console.WriteLine("Rango verificado");
                    Console.WriteLine("Gracias por utilizar el sistema de validación de correlativos");
                    Console.ReadLine();
                 }
                 else if ((Num1 < 1) || (Num2 > 1000))
                    Console.WriteLine("Uno de sus números o los dos estan fuera del correlativo base");
                    Console.ReadLine();
                 }
                    while ((Num1 >= 1) && (Num2 <= 1000));
        }
    }
}

