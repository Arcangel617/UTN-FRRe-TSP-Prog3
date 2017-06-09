using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea310317
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;

            Console.Write("Ingrese primer numero: ");
            numberOne = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo numero: ");
            //numberTwo = int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out numberTwo);

            Console.WriteLine("Resultados:");
            Console.WriteLine("Suma: " + (numberOne + numberTwo));
            Console.WriteLine("Resta: " + (numberOne - numberTwo));
            Console.WriteLine("Producto: " + (numberOne * numberTwo));
            Console.WriteLine("Division: " + (numberOne / numberTwo));
            Console.ReadKey();
        }
    }
}
