using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            // Obtener la fecha de hoy.
            DateTime Hoy = DateTime.Today;
            A = Hoy.ToString();
            //Muestra la fecha en el formato predeterminado (general).
            Console.WriteLine(Hoy);
            Console.WriteLine(Hoy.ToString());
            Console.WriteLine(A);
            //Muestra la fecha en una variedad de formatos.
            Console.WriteLine(Hoy.ToString("d"));
            Console.WriteLine(Hoy.ToString("D"));
            Console.WriteLine(Hoy.ToString("g"));
            Console.ReadLine();
        }
    }
}
