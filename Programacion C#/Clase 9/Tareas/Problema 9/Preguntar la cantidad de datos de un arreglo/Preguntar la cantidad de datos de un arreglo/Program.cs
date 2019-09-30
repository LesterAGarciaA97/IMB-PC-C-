using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preguntar_la_cantidad_de_datos_de_un_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Suma = 0;
            double MediaAritmetica;
            int LimiteIngresos;

            Console.WriteLine("¿Cuántos números quiere ingresar?");
            LimiteIngresos = Convert.ToInt32(Console.ReadLine());

            double[] Numeros = new double[LimiteIngresos];

            for (int i = 0; i <= LimiteIngresos - 1; i = i + 1)
            {
                Console.WriteLine("Ingrese el dato número {0}: ", i + 1);
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Suma = 0;
            for (int i = 0; i <= LimiteIngresos - 1; i = i + 1)
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
