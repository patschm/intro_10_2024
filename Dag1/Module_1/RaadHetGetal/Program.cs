namespace RaadHetGetal;

internal class Program
{
    static void Main(string[] args)
    {
        int hetTeRadenGetal = Random.Shared.Next(1, 5);

        int i = 1;
        for(; i <= 5; i++)
        {
            int gok;
            do
            {
                Console.Write($"{i}de poging. Geef een getal: ");
                string s = Console.ReadLine();
                if (int.TryParse(s, out gok)) break;
                Console.WriteLine($"{s} is een ongeldig getal");
            }
            while (true);

            if (gok == hetTeRadenGetal)
            {
                //Console.WriteLine("Gefeliciteerd. U heeft het getal geraden.");
                break;
            }
            if (i < 5)
                Console.WriteLine("Helaas. Probeer het nogmaals");
        }

        if (i > 5)
       {
            Console.WriteLine($"U heeft verloren. Het te raden getal was {hetTeRadenGetal}");
        }
        else
        {
            Console.WriteLine("Gefeliciteerd. U heeft het getal geraden.");
        }
    }
}
