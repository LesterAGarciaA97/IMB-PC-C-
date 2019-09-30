using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinando_el_signo_ingresado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Signo de puntuación, cifra númerica o carácter?");
            Console.ReadLine();
            char VariableUsuario;
            Console.WriteLine("Ingrese un carácter");
            VariableUsuario = Convert.ToChar(Console.Read());
           
            switch (VariableUsuario)
            {
                case '.':
                    Console.WriteLine("La tecla que usted presionó es un signo de puntuación");
                    Console.ReadLine();
                    break;
                case ',':
                    Console.WriteLine("La tecla que usted presionó es un signo de puntuación");
                    Console.ReadLine();
                    break;
                case ';':
                    Console.WriteLine("La tecla que usted presionó es un signo de puntuación");
                    Console.ReadLine();
                    break;
                case ':':
                    Console.WriteLine("La tecla que usted presionó es un signo puntuación");
                    Console.ReadLine();
                    break;
                case '0':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '1':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '2':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '3':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '4':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '5':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '6':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '7':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '8':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                case '9':
                    Console.WriteLine("La tecla que usted presionó es una cifra numérica");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("La tecla que usted presionó es otro tipo de carácter");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
