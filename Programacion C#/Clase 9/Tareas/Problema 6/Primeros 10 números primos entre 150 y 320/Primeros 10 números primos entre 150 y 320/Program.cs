using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_10_números_primos_entre_150_y_320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primeros diez números entre 150 y 320");
            Console.ReadLine();

            int [] Primos = new int [10];

            Primos[0] = 151;
            Primos[1] = 157;
            Primos[2] = 163;
            Primos[3] = 167;
            Primos[4] = 173;
            Primos[5] = 179;
            Primos[6] = 181;
            Primos[7] = 191;
            Primos[8] = 193;
            Primos[9] = 197;

            Console.WriteLine(Primos[0]);
            Console.WriteLine(Primos[1]);
            Console.WriteLine(Primos[2]);
            Console.WriteLine(Primos[3]);
            Console.WriteLine(Primos[4]);
            Console.WriteLine(Primos[5]);
            Console.WriteLine(Primos[6]);
            Console.WriteLine(Primos[7]);
            Console.WriteLine(Primos[8]);
            Console.WriteLine(Primos[9]);
            Console.ReadLine();
        }
    }
}
