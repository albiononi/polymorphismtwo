using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.Klasser
{
    using polymorphismtwo.NewFolder;
    using System;

    // Circle ärver från Geometry
    public class Circle : Geometry
    {
        // Sparar radien, double gör att vi kan använda decimaltal
        public double Radius { get; set; }

        // Konstruktorn ger cirkeln en radie när den skapas
        public Circle()
        {
            Radius = 4;
        }

        // override gör att cirkeln använder sin egen Area-metod
        // Formeln är pi gånger radien gånger radien
        public override double Area()
        {
            // Math.PI ger oss värdet på pi
            return Math.PI * Radius * Radius;
        }
    }
}
