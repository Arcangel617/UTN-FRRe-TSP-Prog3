using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase25_04
{
    class Program
    {
         /**
         * - Objetivo: implementar varias clases y sus asociaciones.
         * Usar propiedades, enumeraciones o constantes donde se
         * necesite.
         *
         * - Modifique el juego anterior
         * -- Dos jugadores. Dos dados y apuestas
         * -- tres modos de apuesta (conservador -1/2, arriesgado -2/5,
         * desesperado -4/15)
         * -- Cada jugador cuenta con $100 iniciales y un pozo de $10000.
         * -- El juego termina cuando el pozo o el saldo de algun jugador
         * llega a cero.
         *
         * -- Preguntas
         * - ¿En que se diferencias las propiedades, de los campos y
         * metodos?¿Cual es su estructura basica?
         * - ¿Como declara y usa una constante?
         * - ¿Que son las enumeraciones? ¿Que caracteristicas presentan?
         * */
        static void Main(string[] args)
        {
            /*Random nro = new Random();
            int val = 0; ;


            for (int i = 0; i < 10; i++)
            {
                val = nro.Next(1, 7);
                Console.WriteLine(val);
            }

            Console.WriteLine("Arcangel");*/

            int x = (int)dias.Dom;

            Console.WriteLine(dias.Dom);
            Console.WriteLine(meses.ENERO);
            Console.WriteLine(x);



            Console.ReadKey();
        }

        enum dias { Dom, Lun, Mar, Mier, Jue, Vie, Sab };
        enum meses { ENERO, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE, NOVIEMBRE, DICIEMBRE };
        
    }
}
