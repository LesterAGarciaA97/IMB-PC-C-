using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Propuesto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double R;
            Console.WriteLine("Ingrese un número");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            B = Convert.ToInt32(Console.ReadLine());
            R = A / B;
            Console.WriteLine("La division de {0} entre {1} es {2}", A, B, R);
            Console.ReadLine();
            R = (A / B) / A;
            Console.WriteLine("El resto de la división de {0} entre {1} es {2}", A, B, R);
            Console.ReadLine();
        }
    }
}
