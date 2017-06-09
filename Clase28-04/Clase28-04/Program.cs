using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase28_04
{
    class Program
    {
        /**
         * Realice una clase utilitaria de manejo de tiempo y fechas que
         * tenga al menos:
         * - ObtenerDiasCalendario() obtiene los dias entre dos fechas
         * - ObtenerDiasLaborables() obtiene los dias laborables entre dos fechas
         * - SumarDiasLaborables() obtiene una fecha sumando una cantidad de dias
         * a una fecha inicial.
         * 
         * Tenga en cuenta fines de semana y feriados
         * Puede guardar los feriados en un arreglo
         * 
         * */
        static void Main(string[] args)
        {
            Fecha f = new Fecha();

            Console.WriteLine(f.Date.Date);
            Console.ReadKey();

            // timespan está expresado en una unidad de timepo, pero no es una unidad en particular. está expresado en tic
        }
    }
}
