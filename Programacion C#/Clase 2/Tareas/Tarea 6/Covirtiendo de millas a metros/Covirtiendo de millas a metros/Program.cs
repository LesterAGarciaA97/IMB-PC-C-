using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covirtiendo_de_millas_a_metros
{
    class Program
    {
        static void Main(string[] args)
        {
            double Millas;
            double Metros;
            Console.WriteLine("Convertidor de millas a metros");
            Console.ReadLine();
            Console.WriteLine("Ingrese una cantidad de millas:");
            Millas = Convert.ToDouble(Console.ReadLine());
            Metros = Millas * 1609.344;
            Console.WriteLine("Su equivalencia en en metros es: " + Metros);
            Console.ReadLine();
        }
    }
}
