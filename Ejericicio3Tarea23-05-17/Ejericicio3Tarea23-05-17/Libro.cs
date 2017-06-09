using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericicio3Tarea23_05_17
{
    class Libro: IComparable, IColeccionable
    {
        public string Autor{get; set;}
        public string Titulo {get; set;}
        
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
                return this.Titulo.CompareTo(otherLibro.Titulo);
            else
               throw new ArgumentException("Object no es un Libro");
        }

        public override string ToString()
        {
            return "[Título: "+Titulo+"; Autor: "+Autor+"]";
        }
    
    }
}
