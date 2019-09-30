using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrando_la_tabla_de_multiplicar_de_un_número
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumPrincipal;
            Console.WriteLine("Aprendiendo las tablas de multiplicar");
            Console.ReadLine();
            Console.WriteLine("Ingrese un número");
            NumPrincipal = Convert.ToInt32(Console.ReadLine());
            
            if (NumPrincipal > 10)
            {
            Console.WriteLine("Ingrese un número válido entre 1 y 10");
            Console.ReadLine();
            }
            if (NumPrincipal < 1)
            {
            Console.WriteLine("Ingrese un número válido entre 1 y 10");
            Console.ReadLine();
            }
            if (NumPrincipal == 1)
            {
            Console.WriteLine("1 x 1 = 1");
            Console.WriteLine("1 x 2 = 2");
            Console.WriteLine("1 x 3 = 3");
            Console.WriteLine("1 x 4 = 4");
            Console.WriteLine("1 x 5 = 5");
            Console.WriteLine("1 x 6 = 6");
            Console.WriteLine("1 x 7 = 7");
            Console.WriteLine("1 x 8 = 8");
            Console.WriteLine("1 x 9 = 9");
            Console.WriteLine("1 x 10 = 10");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 2)
            {
            Console.WriteLine("2 x 1 = 2");
            Console.WriteLine("2 x 2 = 4");
            Console.WriteLine("2 x 3 = 6");
            Console.WriteLine("2 x 4 = 8");
            Console.WriteLine("2 x 5 = 10");
            Console.WriteLine("2 x 6 = 12");
            Console.WriteLine("2 x 7 = 14");
            Console.WriteLine("2 x 8 = 16");
            Console.WriteLine("2 x 9 = 18");
            Console.WriteLine("2 x 10 = 20");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 3)
            {
            Console.WriteLine("3 x 1 = 3");
            Console.WriteLine("3 x 2 = 6");
            Console.WriteLine("3 x 3 = 9");
            Console.WriteLine("3 x 4 = 12");
            Console.WriteLine("3 x 5 = 15");
            Console.WriteLine("3 x 6 = 18");
            Console.WriteLine("3 x 7 = 21");
            Console.WriteLine("3 x 8 = 24");
            Console.WriteLine("3 x 9 = 27");
            Console.WriteLine("3 x 10 = 30");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 4)
            {
            Console.WriteLine("4 x 1 = 4");
            Console.WriteLine("4 x 2 = 8");
            Console.WriteLine("4 x 3 = 12");
            Console.WriteLine("4 x 4 = 16");
            Console.WriteLine("4 x 5 = 20");
            Console.WriteLine("4 x 6 = 24");
            Console.WriteLine("4 x 7 = 28");
            Console.WriteLine("4 x 8 = 32");
            Console.WriteLine("4 x 9 = 36");
            Console.WriteLine("4 x 10 = 40");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 5)
            {
            Console.WriteLine("5 x 1 = 5");
            Console.WriteLine("5 x 2 = 10");
            Console.WriteLine("5 x 3 = 15");
            Console.WriteLine("5 x 4 = 20");
            Console.WriteLine("5 x 5 = 25");
            Console.WriteLine("5 x 6 = 30");
            Console.WriteLine("5 x 7 = 35");
            Console.WriteLine("5 x 8 = 40");
            Console.WriteLine("5 x 9 = 45");
            Console.WriteLine("5 x 10 = 50");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 6)
            {
            Console.WriteLine("6 x 1 = 6");
            Console.WriteLine("6 x 2 = 12");
            Console.WriteLine("6 x 3 = 18");
            Console.WriteLine("6 x 4 = 24");
            Console.WriteLine("6 x 5 = 30");
            Console.WriteLine("6 x 6 = 36");
            Console.WriteLine("6 x 7 = 42");
            Console.WriteLine("6 x 8 = 48");
            Console.WriteLine("6 x 9 = 54");
            Console.WriteLine("6 x 10 = 60");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 7)
            {
            Console.WriteLine("7 x 1 = 7");
            Console.WriteLine("7 x 2 = 14");
            Console.WriteLine("7 x 3 = 21");
            Console.WriteLine("7 x 4 = 28");
            Console.WriteLine("7 x 5 = 35");
            Console.WriteLine("7 x 6 = 42");
            Console.WriteLine("7 x 7 = 49");
            Console.WriteLine("7 x 8 = 56");
            Console.WriteLine("7 x 9 = 63");
            Console.WriteLine("7 x 10 = 70");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 8)
            {
            Console.WriteLine("8 x 1 = 8");
            Console.WriteLine("8 x 2 = 16");
            Console.WriteLine("8 x 3 = 24");
            Console.WriteLine("8 x 4 = 32");
            Console.WriteLine("8 x 5 = 40");
            Console.WriteLine("8 x 6 = 48");
            Console.WriteLine("8 x 7 = 56");
            Console.WriteLine("8 x 8 = 64");
            Console.WriteLine("8 x 9 = 72");
            Console.WriteLine("8 x 10 = 80");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 9)
            {
            Console.WriteLine("9 x 1 = 9");
            Console.WriteLine("9 x 2 = 18");
            Console.WriteLine("9 x 3 = 27");
            Console.WriteLine("9 x 4 = 36");
            Console.WriteLine("9 x 5 = 45");
            Console.WriteLine("9 x 6 = 54");
            Console.WriteLine("9 x 7 = 63");
            Console.WriteLine("9 x 8 = 72");
            Console.WriteLine("9 x 9 = 81");
            Console.WriteLine("9 x 10 = 90");
            Console.ReadLine();
            }
            else
            if (NumPrincipal == 10)
            {
            Console.WriteLine("10 x 1 = 10");
            Console.WriteLine("10 x 2 = 20");
            Console.WriteLine("10 x 3 = 30");
            Console.WriteLine("10 x 4 = 40");
            Console.WriteLine("10 x 5 = 50");
            Console.WriteLine("10 x 6 = 60");
            Console.WriteLine("10 x 7 = 70");
            Console.WriteLine("10 x 8 = 80");
            Console.WriteLine("10 x 9 = 90");
            Console.WriteLine("10 x 10 = 100");
            Console.ReadLine();
            }

            }
        }
    }

