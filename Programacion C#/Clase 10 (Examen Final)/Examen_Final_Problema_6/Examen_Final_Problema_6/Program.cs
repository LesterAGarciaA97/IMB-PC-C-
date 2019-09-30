using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumInicio;
            int NumFin;

            Console.WriteLine("Ingrese el número con el cual quiere iniciar");
            NumInicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el número con el cual quiere finalizar");
            NumFin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los números que estan desde el número inicial hasta el final son:");

            for (int i = NumInicio; i <= NumFin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " -----> Es un número Par ");
                }
                else if (i % 2 != 0)
                {
                    Console.WriteLine(i + " -----> Es un número Impar ");
                }
            }
                Console.ReadLine();
        }
    }
}
