namespace GissaTalSpel_SOLID_adam___hugo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Gissa Talet!");
            Console.WriteLine("Välj ett nummer mellan 1 och 1000");
            int ValtNummer = 0;
            while (ValtNummer == 0 && (!int.TryParse(Console.ReadLine(), out ValtNummer) || ValtNummer < 1 || ValtNummer > 1000))
            {
                Console.WriteLine("Du måste välja mellan 1 och 1000!");
                ValtNummer = 0;
            }
            Console.WriteLine("Du valde " + ValtNummer + ".");
            Console.WriteLine("Nu gissar datorerna på ditt nummer.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Dator 1 gissar först.");
            Console.ReadLine();
            Dator1 dator1 = new Dator1();
            dator1.GuessNumber(ValtNummer);
            Console.WriteLine("Nu gissar Dator 2.");
            Console.ReadLine();
            Dator2 dator2 = new Dator2();
            dator2.GuessNumber(ValtNummer);
            Console.ReadLine();
        }
    }
}

