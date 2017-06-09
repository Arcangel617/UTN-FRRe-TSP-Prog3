using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11_04
{
    class Program
    {
        /**
         * Calcular la media y la desviación estándar de un conjunto de 10 personas.
         * Tome por teclado la altura en cm de cada persona y cárguela en un arreglo.
         * Presente los resultados obtenidos.
         * Muestre que alturas se encuentran por encima de la media y por debajo de ella.
         * Muestre que alturas se encuentran dentro del rango definido por la desviación
         * estándar.
         * 
         * Referencia: http://www.disfrutalasmatematicas.com/datos/desviacion-estandar.html
         * 
         * Teoría:
         * qué estructuras repetitivas presenta c#
         * en que se diferencian.
         * para que usan break y continue.
         * */
        static void Main(string[] args)
        {
            double[] personas = new double[5];
            double suma = 0;
            double media = 0;
            double varianza = 0;

            /*for (int x = 0; x < 10; x++)
            {
                Console.Write("Persona["+x+"]: ");
                Double.TryParse(Console.ReadLine(), out personas[x]);
            }*/

            personas[0] = 180;
            personas[1] = 160;
            personas[2] = 175;
            personas[3] = 120;
            personas[4] = 150;

            for (int x = 0; x < 5; x++ )
            {
                suma += personas[x];
            }

            media = suma / 5;

            for (int x = 0; x < 5; x++ )
            {
                varianza = varianza + Math.Pow((personas[x] - media),2); 
            }

            
            varianza = varianza / 5;

            Console.WriteLine("Media: "+media);
            Console.WriteLine("Varianza: " + varianza);
            Console.WriteLine("Desviación Estándar: " + Math.Sqrt(varianza));

            Console.WriteLine("Por debajo de la media");
            for (int x = 0; x < 5; x++)
            {
                if (personas[x] < media)
                {
                    Console.WriteLine(personas[x]);
                }
            }
            Console.WriteLine("Por encima de la media");
            for (int x = 0; x < 5; x++)
            {
                if (personas[x] > media)
                {
                    Console.WriteLine(personas[x]);
                }
            }

            Console.ReadKey();
        }
    }
}
