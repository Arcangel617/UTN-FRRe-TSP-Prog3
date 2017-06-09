using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EjercicioClase23_05
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\EJEMPLO");

            foreach (DirectoryInfo subdir in dir.GetDirectories())
            {
                Console.ForegroundColor =  ConsoleColor.Yellow;
                Console.WriteLine("{0}",subdir);
                Console.ResetColor();
            }

            long tam = 0;
            foreach (FileInfo dirf in dir.GetFiles())
            {
                tam += dirf.Length;
                Console.WriteLine("{0} {1}KB", dirf, (dirf.Length / 1024));
            }
            Console.WriteLine("Total: {0}KB", tam / 1024);
            
            Console.ReadLine();
        }
    }
}
