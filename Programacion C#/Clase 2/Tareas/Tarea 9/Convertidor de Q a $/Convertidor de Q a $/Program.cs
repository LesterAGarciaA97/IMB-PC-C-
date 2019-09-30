using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_Q_a__
{
    class Program
    {
        static void Main(string[] args)
        {
            double Quetzales;
            double Dolares;
            double TasaCambio;
            Console.WriteLine("Convirtiendo una cantidad de Quetzales a Dólares");
            Console.ReadLine();
            Console.Write("Ingrese una cantidad monetaria en Q");
            Quetzales = Convert.ToDouble(Console.ReadLine());
            TasaCambio = 7.65343;
            Dolares = Quetzales / TasaCambio;
            Console.WriteLine("El equivalente del monto monetario en dólares es " + "$ " + Dolares);
            Console.ReadLine();
        }
    }
}
