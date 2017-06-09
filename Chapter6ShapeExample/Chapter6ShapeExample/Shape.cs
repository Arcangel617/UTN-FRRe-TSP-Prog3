using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter6ShapeExample
{
    public abstract class Shape
    {
        public Shape(string name = "NoName") {
            PetName = name;
        }

        public string PetName { get; set; }

        public abstract void Draw();

    }
}
