namespace Loopings;

internal class Program
{
    static void Main(string[] args)
    {
        int x = 0;

        // Gebruik als je een blok code 0 of meer keer wilt uitvoeren.
        // Tabel uitlezen.
        // Bestand uitlezen
        while (x < 0)
        {
            x++;
            Console.WriteLine($"De waarde van x is nu {x}");
        }

        // De do-while wordt één of meer keer uitgevoerd.
        // Wordt veel gebruikt bij user input. (validatie ervan)
        do
        {
            x++;
            //if (x == 10) break; // Kapt met de hele loop
            if (x == 10) continue; // Breekt de huidige iteratie af en gaat door met de volgende.
            
            Console.WriteLine($"De waarde van x is nu {x}");
        }
        while (x < 20);
        //x++;
        //Console.WriteLine($"De waarde van x is nu {x}");
        //x++;
        //Console.WriteLine($"De waarde van x is nu {x}");
        //x++;
        //Console.WriteLine($"De waarde van x is nu {x}");
        //x++;
        //Console.WriteLine($"De waarde van x is nu {x}");

    }
}
