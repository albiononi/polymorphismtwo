using polymorphismtwo.NewFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphismtwo.Klasser
{
    // Rectangle ärver från Geometry och kan skriva över Area-metoden.
    public class Rectangle : Geometry
    {
        // Width och Height sparar rektangelns bredd och höjd.
        // double gör att måtten också kan innehålla decimaler.
        public double Width { get; set; }
        public double Height { get; set; }

        // Konstruktorn körs när en Rectangle skapas.
        // Här får bredden och höjden fasta värden.
        public Rectangle()
        {
            Width = 5.92;
            Height = 4;
        }

        // Här använder vi override för att räkna ut rektangelns area.
        // Formeln är bredd gånger höjd.
        public override double Area()
        {
            return Width * Height;
        }
    }
}
