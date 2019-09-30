using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Media_Aritmetica__Arreglos_
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1;
            double Num2;
            double Num3;
            double Num4;
            double Media;
            //Pedir al usuario cuatro números y almacenarlos
            Console.WriteLine("Ingrese un primer número");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un tercer número");
            Num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un último número");
            Num4 = Convert.ToInt32(Console.ReadLine());
            //Asignarle valor a cada dirección del arreglo con los números previamente almacenados
            double[] Numeros = new double[4];
            Numeros[0] = Num1;
            Numeros[1] = Num2;
            Numeros[2] = Num3;
            Numeros[3] = Num4;
            //Salto o espacio entre líneas
            Console.WriteLine("");
            Console.ReadLine();
            //Desplegar en consola los números tecleados por el usuario
            Console.WriteLine(Numeros[0]);
            Console.WriteLine(Numeros[1]);
            Console.WriteLine(Numeros[2]);
            Console.WriteLine(Numeros[3]);
            Console.ReadLine();
            //Mostrar en consola la media aritmética de los cuatro números almacenados en el arreglo
            Media = ((Numeros[0] + Numeros[1] + Numeros[2] + Numeros[3]) / 4);
            Console.WriteLine("La media aritmética de sus números ingresados es: " + Media);
            Console.ReadLine();
        }
    }
}
