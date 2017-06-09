using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase21_04
{
    class Program
    {
        /**
         * - Implementar una funcion moda, que reciba como valores una cantidad indeterminada
         * de enteros y devuelva la moda (estadistica), el valor minimo y el valor máximo.
         * - Invocar este método y mostrar los resultados por consola
         * - Elija los modificadores demas adecuados.
         * */
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 5, 7, 8, 9, 5, 8, 1, 3, 0};
            
            Console.WriteLine(arr.ToString());
            Array.Sort(arr);
            Console.WriteLine(arr.ToString());

            int[] dis = arr.Distinct().ToArray();
            Console.WriteLine(dis.ToString());

            //Console.WriteLine(Array.FindAll(arr, s =>  s == 5).Length);

            //int val = 0;
            //int cant = 0;

            /*for (int i = 0; i < arr.Length; i++)
            {
                val = arr[0];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        cant++;
                }
                
            }*/
            
            Console.ReadKey();
        }

        static void calcularModa()
        {
            Console.WriteLine("Mensaje!");
        }

        static void recorrer() { 
        }
    }
}
