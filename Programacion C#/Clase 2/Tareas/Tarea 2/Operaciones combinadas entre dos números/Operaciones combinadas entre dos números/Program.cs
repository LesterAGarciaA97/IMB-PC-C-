using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_combinadas_entre_dos_números
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones combinadas");
            Console.ReadLine();
            double A;
            double B;
            double Resultado;
            Console.WriteLine("Ingrese un número");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            B = Convert.ToDouble(Console.ReadLine());
            Resultado = Convert.ToDouble((A + B) * (A - B));
            Console.WriteLine("El resultado de la operación (a+b)*(a-b) es: " + Resultado);
            Console.ReadLine();
            Resultado = Convert.ToDouble((2 * A) - (2 * B));
            Console.WriteLine("El resultado de la operación a2-b2 es: " + Resultado);
            Console.ReadLine();
        }
    }
}
