using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;


namespace Ejericicio3Tarea23_05_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            EjemploList2();
            
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}ms",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine("RunTime "+elapsedTime);
            Console.ReadLine();
        }


        static void EjemploArrayList()
        {
            int elementos = 1000000;

            ArrayList libros = new ArrayList();

            for (int i = 0; i < elementos; i++)
            {
                libros.Add(new Libro(Util.RandomString(6) + ", " + Util.RandomString(10), Util.RandomString(15)));
            }

            libros.Sort();
        }

        static void EjemploList()
        {
            int elementos = 1000000;

            List<Libro> libros = new List<Libro>();

            for (int i = 0; i < elementos; i++)
            {
                libros.Add(new Libro(Util.RandomString(6) + ", " + Util.RandomString(10), Util.RandomString(15)));
            }

            libros.Sort();
        }


        static void EjemploList2()
        {
            int elementos = 1000000;

            List<Libro2> libros = new List<Libro2>();

            for (int i = 0; i < elementos; i++)
            {
                libros.Add(new Libro2(Util.RandomString(6) + ", " + Util.RandomString(10), Util.RandomString(15)));
            }

            libros.Sort();
        }


        /*static void EjemploArrayList2()
        {
            int elementos = 100000;

            ArrayList libros = new ArrayList();

            for (int i = 0; i < elementos; i++)
            {
                libros.Add(new Libro2<String>(Util.RandomString(6) + ", " + Util.RandomString(10), Util.RandomString(15)));
            }

            libros.Sort();
        }*/
    }
}
