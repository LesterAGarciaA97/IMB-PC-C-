using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Final_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {

            double SalarioBase;
            double Ventas;
            double Comision1 = 0.05;
            double Comision2 = 0.10;
            double Comision3 = 0.15;
            double SalarioParcial1;
            double SalarioParcial2;
            double SalarioParcial3;
            double SalarioFinal1;
            double SalarioFinal2;
            double SalarioFinal3;

            Console.WriteLine("Bienvenido al sistema de cálculo de salarios");
            Console.ReadLine();

            Console.Write("¿Cuál es su salario base? Q ");
            SalarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Para calcular su % de comisión, ingrese el total de sus ventas realizadas: Q ");
            Ventas = Convert.ToDouble(Console.ReadLine());

            if (Ventas < 0)
            {
                Console.WriteLine("Usted no realizó ninguna venta, por lo tanto, no tedrá pago de comisión");
                Console.WriteLine("Su salario de este mes será de: Q " + SalarioBase);
                Console.ReadLine();
            }
            else if ((Ventas > 0) && (Ventas <= 6000))
            {
                SalarioParcial1 = (Ventas * Comision1); 
                SalarioFinal1 = (SalarioBase + SalarioParcial1);
                Console.WriteLine("Su salario de este mes será de: Q" + SalarioFinal1);
                Console.ReadLine();
            }
            else if ((Ventas > 6000) && (Ventas <= 12000))
            {
                SalarioParcial2 = (Ventas * Comision2);
                SalarioFinal2 = (SalarioBase + SalarioParcial2);
                Console.WriteLine("Su salario de este mes será de: Q" + SalarioFinal2);
                Console.ReadLine();
            }
            else
            {
                SalarioParcial3 = (Ventas * Comision3);
                SalarioFinal3 = (SalarioBase + SalarioParcial3);
                Console.WriteLine("Su salario de este mes será de: Q" + SalarioFinal3);
                Console.ReadLine();
            }


            Console.WriteLine("Ahora, se le dará una calificación dependiendo su desempeño en ventas de este mes");
            Console.ReadLine();

            Console.Write("Para determinar su calificación, ingrese el total de sus ventas realizadas: Q ");
            Ventas = Convert.ToDouble(Console.ReadLine());

           if (Ventas <= 0)
            {
                Console.WriteLine("MALO");
                Console.WriteLine("Su comisión total a cobrar es 0");
                Console.ReadLine();
            }
            else if ((Ventas > 0) && (Ventas <= 20000))
            {
                Console.WriteLine("Regular");
                Console.WriteLine("Su comisión total a cobrar está entre 0 y 3000");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bueno");
                Console.WriteLine("Su comisión total a cobrar está por encima de los 3000");
                Console.ReadLine();
            }
        }
    }
}
