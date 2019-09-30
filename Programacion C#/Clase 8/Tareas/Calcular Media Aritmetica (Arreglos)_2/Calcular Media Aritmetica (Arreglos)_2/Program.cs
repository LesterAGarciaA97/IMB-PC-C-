using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Media_Aritmetica__Arreglos__2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Suma = 0;
            double MediaAritmetica;

            double[] Numeros = new double[4];

           for (int i = 0; i <= 3; i = i +1)
            {
                Console.WriteLine("Ingrese el dato número {0}: ", i + 1);
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
           }
                Suma = 0;
                for (int i = 0; i <= 3; i = i + 1)
                {
                    Suma += Numeros[i];
                    Console.WriteLine("Su suma total es {0}", Suma);
                    Console.ReadLine();
                }

                MediaAritmetica = Suma / 4;
                Console.WriteLine("El resultado de la media aritmética es: " + MediaAritmetica);
                Console.ReadLine();
        }
    }
}
