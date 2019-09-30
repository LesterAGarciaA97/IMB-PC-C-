using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribiendo el nombre completo de un número");
            Console.ReadLine();
            int NumIngresado;
            Console.WriteLine("Ingrese un número entero");
            NumIngresado = Convert.ToInt32(Console.ReadLine());

            if (NumIngresado == 1)
            {
                    Console.WriteLine("Uno");
                    Console.ReadLine();
            }
            else if (NumIngresado == 2)
            {
                    Console.WriteLine("Dos");
                    Console.ReadLine();
            }
            else if (NumIngresado == 3)
            {
                    Console.WriteLine("Tres");
                    Console.ReadLine();
            }
            else if (NumIngresado == 4)
            {
                    Console.WriteLine("Cuatro");
                    Console.ReadLine();
            }
            else if (NumIngresado == 5) 
            {
                    Console.WriteLine("Cinco");
                    Console.ReadLine();
            }
                    
            }
        }
