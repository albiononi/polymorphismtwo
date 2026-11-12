using polymorphismtwo.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.Klasser
{
    // Rectangle ärver från Geometry
    public class Rectangle : Geometry
    {
        // Sparar rektangelns bredd och höjd
        public double Width { get; set; }
        public double Height { get; set; }

        // Konstruktorn ger rektangeln sina mått
        public Rectangle()
        {
            Width = 5.92;
            Height = 4;
        }

        // override gör att vi kan använda rektangelns egen Area
        // Arean räknas ut med bredd gånger höjd
        public override double Area()
        {
            return Width * Height;
        }
    }
}
