using polymorphismtwo.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.Klasser
{
    // Square ärver från Geometry, precis som Circle.
    public class Square : Geometry
    {
        // Side sparar längden på en sida av kvadraten.
        public double Side { get; set; }

        // Konstruktorn ger sidan ett fast värde när objektet skapas.
        public Square()
        {
            Side = 8;
        }

        // Med override får Square sin egen uträkning av Area.
        // Vi multiplicerar sidan med sig själv eftersom alla sidor är lika långa.
        public override double Area()
        {
            return Side * Side;
        }
    }
}
