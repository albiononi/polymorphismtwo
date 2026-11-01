using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.Klasser
{
    using polymorphismtwo.NewFolder;
    using System;

    // : Geometry betyder att Circle ärver från huvudklassen Geometry.
    public class Circle : Geometry
    {
        // Radius sparar cirkelns radie. Vi använder double för att kunna ha decimaltal.
        public double Radius { get; set; }

        // Konstruktorn körs när vi skapar en ny Circle.
        // Vi ger radien ett fast värde, precis som uppgiften ber om.
        public Circle()
        {
            Radius = 4;
        }

        // override gör att Circle använder sin egen Area-metod i stället
        // för den som finns i Geometry. En cirkels area är pi * radie * radie.
        public override double Area()
        {
            // Math.PI ger oss värdet på pi.
            return Math.PI * Radius * Radius;
        }
    }
}
