using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase19_05
{
    class Program
    {
        /**
         * - Cree una interfaz IColeccionable y luego implementela en una clase Libro
         * - Almacenelos en un arreglo llamado biblioteca
         * - Ordenar el arreglo y mostrar los resultados
         * */
        static void Main(string[] args)
        {
            List<Libro> biblioteca = new List<Libro>();

            biblioteca.Add(new Libro("Artigue Arcangel", "Mi libro"));
            biblioteca.Add(new Libro("Artigue Manuel", "Libro de Manuel"));
            biblioteca.Add(new Libro("Artigue Horacio", "Finanzas"));

            Console.WriteLine("SIN ORDENAR");
            foreach (Libro l in biblioteca) {
                Console.WriteLine(l);
            }

            biblioteca.Sort();

            Console.WriteLine("ORDENADO");

            foreach (Libro l in biblioteca)
            {
                Console.WriteLine(l);
            }

            Console.ReadKey();
        }
    }
}
