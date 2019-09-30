using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_inverso_de_un_arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[]Numeros = new double [6];

            Console.WriteLine("Ingrese un número");
            Numeros[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            Numeros[1] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un tercer número");
            Numeros[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un cuarto número");
            Numeros[3] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un quinto número");
            Numeros[4] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un último número");
            Numeros[5] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Orden original de los números ingresados");
            Console.WriteLine(Numeros[0]);
            Console.WriteLine(Numeros[1]);
            Console.WriteLine(Numeros[2]);
            Console.WriteLine(Numeros[3]);
            Console.WriteLine(Numeros[4]);
            Console.WriteLine(Numeros[5]);
            Console.ReadLine();

            Console.WriteLine("Orden inverso de los números ingresados");
            Console.WriteLine(Numeros[5]);
            Console.WriteLine(Numeros[4]);
            Console.WriteLine(Numeros[3]);
            Console.WriteLine(Numeros[2]);
            Console.WriteLine(Numeros[1]);
            Console.WriteLine(Numeros[0]);
            Console.ReadLine();
        }
    }
}
