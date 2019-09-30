using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla_de_multiplicar_del_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabla de multiplicar del número 9");
            Console.ReadLine();

            double NumPrincipal = 9;

            double[] TabladeMultiplicar = new double[11];
            TabladeMultiplicar[0] = 0;
            TabladeMultiplicar[1] = 1;
            TabladeMultiplicar[2] = 2;
            TabladeMultiplicar[3] = 3;
            TabladeMultiplicar[4] = 4;
            TabladeMultiplicar[5] = 5;
            TabladeMultiplicar[6] = 6;
            TabladeMultiplicar[7] = 7;
            TabladeMultiplicar[8] = 8;
            TabladeMultiplicar[9] = 9;
            TabladeMultiplicar[10] = 10;

            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[0] + " = " + (NumPrincipal * TabladeMultiplicar[0]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[1] + " = " + (NumPrincipal * TabladeMultiplicar[1]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[2] + " = " + (NumPrincipal * TabladeMultiplicar[2]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[3] + " = " + (NumPrincipal * TabladeMultiplicar[3]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[4] + " = " + (NumPrincipal * TabladeMultiplicar[4]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[5] + " = " + (NumPrincipal * TabladeMultiplicar[5]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[6] + " = " + (NumPrincipal * TabladeMultiplicar[6]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[7] + " = " + (NumPrincipal * TabladeMultiplicar[7]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[8] + " = " + (NumPrincipal * TabladeMultiplicar[8]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[9] + " = " + (NumPrincipal * TabladeMultiplicar[9]));
            Console.WriteLine(NumPrincipal + " x " + TabladeMultiplicar[10] + " = " + (NumPrincipal * TabladeMultiplicar[10]));
            Console.ReadLine();
        }
    }
}
