using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.NewFolder
{
    // Geometry är huvudklassen som våra tre figurer ärver från.
    // Vi har en gemensam Area-metod så att alla figurer kan använda samma metodnamn.
    public class Geometry
    {
        // virtual betyder att klasser som ärver från Geometry kan göra
        // en egen version av Area-metoden med hjälp av override.
        public virtual double Area()
        {
            // Geometry är ingen särskild figur, så här har vi ingen area att räkna ut.
            // Därför returnerar metoden 0. Underklasserna gör sina egna uträkningar.
            return 0;
        }
    }
}