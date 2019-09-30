using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            double CostosFijo;
            double CostosVari;
            double SueldoEmpleados;
            double SueldoEmpresaria;
            double Alquiler;
            double Herramientas;
            double Servicios;
            double Mobiliario;
            double Fresas;
            double Piñas;
            double Naranjas;
            double Azucar;
            double Envases;
            double Gas;
            double CostoTotalProduccion;
            double CostoUnitario;
            double Produccion;
            double TasaCambio = 7.67830;
            double CostoGanancia = 5;

            Console.WriteLine("Sistema de ventas de Mermeladas S.A.");
            Console.ReadLine();

            Console.WriteLine("Ingrese los costos fijos totales que se le solicitan");
            Console.ReadLine();
            Console.Write("Sueldo de los empleados: $ ");
            SueldoEmpleados = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sueldo propio: $ ");
            SueldoEmpresaria = Convert.ToDouble(Console.ReadLine());
            Console.Write("Pago de alquiler del local: $ ");
            Alquiler = Convert.ToDouble(Console.ReadLine());
            Console.Write("Herramientas y utensilios requeridos: $ ");
            Herramientas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Servicios (Agua, luz y teléfono): $ ");
            Servicios = Convert.ToDouble(Console.ReadLine());
            Console.Write("Mobiliario (muebles, repisas, etc.): $ ");
            Mobiliario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Calculando costos fijos... Espere un momento");
            Console.ReadLine();
            CostosFijo = SueldoEmpleados + SueldoEmpresaria + Alquiler + Herramientas + Servicios + Mobiliario;
            Console.WriteLine("Su total de costos fijos es de: " + "$" + CostosFijo);
            Console.ReadLine();

            Console.WriteLine("Ahora, se calculará el total de gastos variables");
            Console.ReadLine();
            Console.WriteLine("Ingrese los costos variables totales que se le solicitan");
            Console.ReadLine();
            Console.Write("Fresas: $ ");
            Fresas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Piñas: $ ");
            Piñas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Naranjas: $ ");
            Naranjas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Azúcar: $ ");
            Azucar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Envases: $ ");
            Envases = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gas: $ ");
            Gas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Calculando costos variables... Espere un momento");
            Console.ReadLine();
            CostosVari = Fresas + Piñas + Naranjas + Azucar + Envases + Gas;
            Console.WriteLine("Su total de costos fijos es de: " + "$" + CostosVari);
            Console.ReadLine();

            Console.WriteLine("Con estos datos, se calculará el costo total de producción");
            Console.ReadLine();

            Console.WriteLine("Calculando costo total de producción... Espere un momento");
            Console.ReadLine();

            CostoTotalProduccion = CostosFijo + CostosVari;
            Console.WriteLine("El costo total de producción es de: $ " + CostoTotalProduccion);
            Console.WriteLine("El costo total de producción en Q es de: Q " + CostoTotalProduccion * TasaCambio);
            Console.ReadLine();

            Console.WriteLine("Ahora, se procederá a calcular el costo unitario");
            Console.ReadLine();

            Console.WriteLine("¿Qué cantidad de mermeladas tiene proyectado producir?");
            Produccion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Calculando costo total unitario... Espere un momento");
            Console.ReadLine();

            CostoUnitario = CostoTotalProduccion / Produccion;
            Console.WriteLine("El costo total unitario es de: $ " + CostoUnitario);
            Console.WriteLine("El costo total unitario en Quetzales es de: Q " + CostoUnitario / TasaCambio);
            Console.ReadLine();
            Console.WriteLine("El costo total por la produccion de " + Produccion + " mermeladas es de: $ " + Produccion * CostoUnitario);
            Console.ReadLine();

            Console.WriteLine("Si quiere tener una ganancia debe de vender cada mermelada a mas de:");
            Console.ReadLine();
            Console.WriteLine("$ " + CostoGanancia);
            Console.WriteLine("Q " + CostoGanancia * TasaCambio);
            Console.ReadLine();

            Console.WriteLine("Gracias por utilizar el sistemas de ventas Mermeladas S.A.");
            Console.ReadLine();
        }
    }
}
