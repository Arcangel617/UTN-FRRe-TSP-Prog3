using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio3Tarea23_05_17
{
    class Libro2 : IComparable<Libro2>, IColeccionable
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }

        public Libro2() { }
        public Libro2(string A, string T)
        {
            Autor = A;
            Titulo = T;
        }

        public void Describir() { }

        /*public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Libro otherLibro = obj as Libro;
            if (otherLibro != null)
                return this.Titulo.CompareTo(otherLibro.Titulo);
            else
                throw new ArgumentException("Object no es un Libro");
        }*/

        public int CompareTo(Libro2 other)
        {
            if (other == null) return 1;

            return Titulo.CompareTo(other.Titulo);
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType() != GetType())
                return -1;
            return CompareTo(obj as Libro2);
        }

        public override string ToString()
        {
            return "[Título: " + Titulo + "; Autor: " + Autor + "]";
        }
    }
}
