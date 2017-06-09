using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8CustomInterfacesExample
{
    // The pointy behaviour as a read-only property.
    interface IPointy
    {
        // A read-write property in an interface would look like:
        // retType PropName { get; set; }
        //
        // while a write-only property in an interface would be:
        // retType PropName { set; }
        byte Points { get; }
    }
}
