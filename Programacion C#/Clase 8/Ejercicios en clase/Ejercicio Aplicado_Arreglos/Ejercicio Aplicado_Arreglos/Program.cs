using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Aplicado_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Suma;
            int[] Numeros = new int[5];
            Numeros[0] = 1;
            Numeros[1] = 2;
            Numeros[2] = 3;
            Numeros[3] = 4;
            Numeros[4] = 5;
            //Enlistando cada elemento del arreglo y desplegandolo en lista
            Console.WriteLine(Numeros[0]);
            Console.WriteLine(Numeros[1]);
            Console.WriteLine(Numeros[2]);
            Console.WriteLine(Numeros[3]);
            Console.WriteLine(Numeros[4]);
            Console.ReadLine();
            Suma = Numeros[0] + Numeros[1] + Numeros[2] + Numeros[3] + Numeros[4];
            Console.WriteLine("La suma de los números es: " + Suma);
            Console.ReadLine();
            //Asignarle a una variable una posicion/dirección del arreglo y desplegarlo en consola
            int Indice = Numeros[0];
            Console.WriteLine(Indice);
            Console.ReadLine();
        }
    }
}
