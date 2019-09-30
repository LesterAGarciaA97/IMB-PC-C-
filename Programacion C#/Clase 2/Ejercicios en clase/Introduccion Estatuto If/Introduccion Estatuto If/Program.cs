using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_Estatuto_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            Console.WriteLine("El número es positivo.");
            Console.ReadLine();
        }
    }
}
