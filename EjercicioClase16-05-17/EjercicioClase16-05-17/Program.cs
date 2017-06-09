using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AhorcadoPalabras;

namespace EjercicioClase16_05_17
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey opcion = ConsoleKey.Enter;
            do{
                Console.Clear();
                jugar(6);
                Console.Write("\nContinuar? Salir = [0]");
                opcion = Console.ReadKey().Key;
            } while (opcion != ConsoleKey.D0);
            
            //Console.ReadKey();
        }
        
        static void jugar(int op) {
            GeneradorPalabras gp = new GeneradorPalabras();
            List<string> letras = new List<string>();
            string palabra = gp.SiguientePalabra;
            char[] result = new char[palabra.Length];
            char letra;

            // precargo el resultado
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = '-';
            }
            
            while (op != 0 && result.Contains('-'))
            {
                Console.WriteLine("OPORTUNIDADES: " + op);
                Console.Write("\nINGRESE LETRA: ");
                letra = checkPalabra(Console.ReadKey().KeyChar, palabra);

                

                // registro la letra ingresada, no importa si son repetidas

                if (!palabra.Contains(letra))
                    op--;

                if (letras.Contains(letra.ToString()))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYA UTILIZASTE ESA LETRA!");
                    Console.ResetColor();
                    op--;
                }

                letras.Add(letra.ToString());

                Console.WriteLine();

                // busco las coincidencias
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra)
                    {
                        result[i] = letra;
                    }
                }

                // muestro el resultado parcial
                Console.Write("\nPALABRA: ");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write(result[i]);
                }
                Console.WriteLine();
            }

            if (op == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPERDISTE!");
                Console.ResetColor();
                Console.WriteLine("PALABRA: " + palabra);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nGANASTE!");
                Console.ResetColor();
            }

            // muestro las letras utilizadas
            Console.WriteLine("LETRAS UTILIZADAS: ");
            foreach (string l in letras)
            {
                Console.Write(l);
            }
        }

        static char checkPalabra(char l, string p)
        {
            switch (l)
            {
                case 'a': if (p.Contains('á')) return 'á';
                    break;
                case 'e': if (p.Contains('é')) return 'é';
                    break;
                case 'i': if (p.Contains('í')) return 'í';
                    break;
                case 'o': if (p.Contains('ó')) return 'ó';
                    break;
                case 'u': if (p.Contains('ú')) return 'ú';
                    break;
            }
            return l;
        }
    }
}
