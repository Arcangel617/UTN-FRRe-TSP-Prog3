using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca b = new Biblioteca();

            b.AddLibro(new Libro("Arcangel", "Libro de Arcangel"));
            b.AddLibro(new Libro("Franco", "Libro de Franco"));
            b.AddLibro(new Libro("Andrés", "Libro de Andres"));

            Console.WriteLine(b);

            foreach (Libro l in b)
            {
                Console.WriteLine(l.Titulo);
            }

            Console.ReadLine();
        }
    }
}
