namespace polymorphismtwo
{
    using polymorphismtwo.Klasser;
    using polymorphismtwo.NewFolder;
    using System;

    public class Program
    {
        static void Main()
        {
            // Skapar tre figurer som alla ärver från Geometry
            // Vi använder Geometry som typ för att kunna samla dem i samma array
            Geometry[] figures =
            {
            new Circle(),
            new Square(),
            new Rectangle()
        };

            // foreach går igenom alla figurer, en i taget
            foreach (Geometry figure in figures)
            {
                // Polymorfism: samma Area-metod används
                // men varje figur gör sin egen uträkning
                // GetType().Name hämtar namnet på figuren
                // 0.## visar högst två decimaler
                Console.WriteLine($"Area of {figure.GetType().Name}: {figure.Area():0.##}");
            }
        }
    }
}