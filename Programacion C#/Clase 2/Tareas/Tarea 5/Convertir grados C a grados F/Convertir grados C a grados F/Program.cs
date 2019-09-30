using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir_grados_C_a_grados_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertidor de Grados °C a °F y Kelvin");
            Console.ReadLine();
            double Temp1;
            double Resultado1;
            double Resultado2;
            Console.WriteLine("Ingrese una temperatura");
            Temp1 = Convert.ToDouble(Console.ReadLine());
            Resultado1 = ((9/5)*(Temp1)+32);
            Console.WriteLine("La temperatura equivalente en °F es: " + Resultado1 + " °F");
            Console.ReadLine();
            Resultado2 = Temp1 + 273.15;
            Console.WriteLine("La temperatura equivalente en K (Kelvin) es: " + Resultado2 + " K");
            Console.ReadLine();
       }
    }
}
