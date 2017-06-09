using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase310317
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cree una aplicación de consola
             * Solicite el ingreso de un texto y controle que no esté vacio
             * Despliegue el manu que muestre 3 posibilidades (texto en mayuscula, minuscula y original)
             * capture la entrada con Console.ReadKey y realice la opción solicitada
             * */

            string texto;
            ConsoleKeyInfo opcion;
            Console.Write("Ingrese un texto: ");
            texto = Console.ReadLine();

            Console.WriteLine("Seleccione un opción:");
            Console.WriteLine("1- Mostrar texto en mayúscula");
            Console.WriteLine("2- Mostrar texto en minúscula");
            Console.WriteLine("3- Mostrar texto original");
            Console.Write("Opción: ");
            opcion = Console.ReadKey();

            switch (opcion.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n" + texto.ToUpper());
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\n" + texto.ToLower());
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("\n" + texto);
                    break;
                default:
                    Console.WriteLine("\nopcion incorrecta");
                    break;
            }

            Console.ReadKey();

        }
    }
}
