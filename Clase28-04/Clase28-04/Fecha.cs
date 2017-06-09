using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase28_04
{
    class Fecha
    {
        const string year = "2017";
        private string[] diasFeriados = { 
                                            "27/02"+year, 
                                            "28/02"+year, 
                                            "24/03"+year, 
                                            "02/04"+year, 
                                            "13/04"+year, 
                                            "14/04"+year, 
                                            "15/04"+year, 
                                            "01/05"+year, 
                                            "02/05"+year, 
                                            "25/05"+year
                                        };
        
 
        /**
         *  obtiene los dias entre dos fechas
         * */
        public int ObtenerDiasCalendario()
        {
            return 0;
        }
        
        /**
         * obtiene los dias laborables entre dos fechas
         * */
        public int ObtenerDiasLaborables()
        {
            return 0;
        }

        /**
         * obtiene una fecha sumando una cantidad de dias
         * */
        public Fecha SumarDiasLaborables()
        {
            return new Fecha();
        }

        public override string ToString()
        {
            return " ";
        }
    }
}
