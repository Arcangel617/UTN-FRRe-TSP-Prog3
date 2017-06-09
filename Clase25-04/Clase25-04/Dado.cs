using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase25_04
{
    class Dado
    {
        private string[] caras = { "uno", "dos", "tres", "cuatro", "cinco", "seis" };
        private Random rnd = new Random();

        public int Lanzar() {
            return 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("A");
            return sb.ToString();

        }
    }
}
