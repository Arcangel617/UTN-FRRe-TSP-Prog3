using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase11_04
{
    class Persona
    {
        private string nombre;
        private string email;
        private int edad;

        public Persona(string N, string E, int Ed)
        {
            Nombre = N;
            Email = E;
            Edad = Ed;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public override string ToString()
        {
            return "[Nombre: "+Nombre+"; Edad: "+Edad+"; E-mail: "+Email+"]";
        }
    }
}
