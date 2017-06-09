using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    class Biblioteca: IEnumerable
    {
        private ArrayList bLibros = new ArrayList();
        
        // Cast for caller.
        public Libro GetPerson(int pos)
        { return (Libro)bLibros[pos]; }
        
        // Insert only Person objects.
        public void AddLibro(Libro p)
        { bLibros.Add(p); }
        
        public void ClearPeople()
        { bLibros.Clear(); }
        
        public int Count
        { get { return bLibros.Count; } }
        
        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator()
        { return bLibros.GetEnumerator(); }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Libro l in this) {
                sb.Append(l+"\n");
            }
            return sb.ToString();
        }
    }
}
