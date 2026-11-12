using polymorphismtwo.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.Klasser
{
    // Square ärver från Geometry
    public class Square : Geometry
    {
        // Sparar längden på kvadratens sida
        public double Side { get; set; }

        // Ger sidan ett värde när kvadraten skapas
        public Square()
        {
            Side = 8;
        }

        // Med override ändrar vi Area till kvadratens uträkning
        // Vi multiplicerar sidan med sig själv
        public override double Area()
        {
            return Side * Side;
        }
    }
}
