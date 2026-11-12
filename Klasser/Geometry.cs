using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.NewFolder
{
    // Basklassen som alla våra figurer ärver från
    public class Geometry
    {
        // virtual gör att de andra figurerna kan ändra Area
        // På så sätt kan varje figur ha sin egen uträkning
        public virtual double Area()
        {
            // Returnerar 0 eftersom Geometry inte har någon egen form
            return 0;
        }
    }
}