using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double Contador;
            Contador = 0;

            while (Contador <= 7)
            {
                Console.WriteLine(Convert.ToString(Contador));
                Contador = Contador + 1;
            }

            do
            {
                Contador += 2;
                Console.WriteLine(Convert.ToString(Contador));
            }
            while (Contador < 30);

            do
            {
                Contador += 3;
                Console.WriteLine(Convert.ToString(Contador));
            }
            while (Contador < 40);

            while (Contador <= 75)
            {
                Console.WriteLine(Convert.ToString(Contador));
                Contador+=5;
            }
                Console.ReadLine();
        }
    }
}
