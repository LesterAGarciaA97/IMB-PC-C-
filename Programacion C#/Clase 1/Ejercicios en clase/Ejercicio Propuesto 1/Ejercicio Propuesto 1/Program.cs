using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Propuesto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int R;
            Console.WriteLine("Ingrese un número");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            B = Convert.ToInt32(Console.ReadLine());
            R = A * B;
            Console.WriteLine("El producto de {0} y {1} es {2}", A, B, R);
            Console.ReadLine();
        }
    }
}
