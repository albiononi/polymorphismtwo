namespace polymorphismtwo
{
    using polymorphismtwo.Klasser;
    using polymorphismtwo.NewFolder;
    using System;

    public class Program
    {
        static void Main()
        {
            // Här skapar vi tre objekt, ett av varje figur.
            // Vi använder Geometry som typ för alla objektreferenser
            // eftersom Circle, Square och Rectangle ärver från Geometry.
            Geometry[] figures =
            {
            new Circle(),
            new Square(),
            new Rectangle()
        };

            // foreach går igenom figurerna i arrayen en i taget.
            // figure är den figur som vi arbetar med just nu.
            foreach (Geometry figure in figures)
            {
                // Här använder vi polymorfism: vi anropar samma Area-metod,
                // men programmet väljer rätt uträkning beroende på objektets klass.
                // GetType().Name hämtar figurens klassnamn till utskriften.
                // 0.## visar högst två decimaler, utan onödiga nollor.
                Console.WriteLine($"Area of {figure.GetType().Name}: {figure.Area():0.##}");
            }
        }
    }
}