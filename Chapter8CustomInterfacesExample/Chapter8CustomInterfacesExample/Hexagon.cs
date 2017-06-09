using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter8CustomInterfacesExample
{
    public class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        // IPointy implementation.
        public byte Points
        {
            get { return 6; }
        }
    }
}
