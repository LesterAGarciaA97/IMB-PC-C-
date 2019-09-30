using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_Write_en_lugar_de_WrtieLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("División de dos números");
            Console.ReadLine();
            double A;
            double B;
            double Resultado;
            //Usar Write en lugar de WriteLine 
            Console.Write("Ingrese un número: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese un segundo número: ");
            B = Convert.ToDouble(Console.ReadLine());
            Resultado = A / B;
            Console.Write("El reultado de la división entre los dos números ingresados es: " + Resultado);
            Console.ReadLine();
            //Nombre propio y fecha en que se realizó el programa
            string Nombre;
            string Fecha;
            Nombre = "Lester Andrés García Aquino";
            DateTime Hoy = DateTime.Today;
            Fecha = Hoy.ToString();
            Console.WriteLine(Hoy);
            Console.ReadLine();
            Console.WriteLine(Nombre);
            Console.ReadLine();
        }
    }
}
