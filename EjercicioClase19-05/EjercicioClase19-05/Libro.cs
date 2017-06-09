using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase19_05
{
    class Libro: IColeccionable, IComparable
    {
        private string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }


        public Libro() { }
        public Libro(string A, string T) {
            Autor = A;
            Titulo = T;
        }

        public void Describir() { }

        public int CompareTo(object obj) {
        if (obj == null) return 1;

        Libro otherLibro = obj as Libro;
        if (otherLibro != null) 
            return this.Titulo.CompareTo(otherLibro.titulo);
        else
           throw new ArgumentException("Object no es un Libro");
    }

        public override string ToString()
        {
            return "[Tutilo: "+Titulo+"; Autor: "+Autor+";]";
        }
    }
}
