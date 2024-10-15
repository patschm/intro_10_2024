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
            
            //Console.WriteLine($"De waarde van x is nu {x}");
        }
        while (x < 20);

        // Bij de vorige loopings weet je niet hoe vaak ze uitgevoerd worden.
        // Wanneer je wel weet hoe vaak je iets moet herhalen, kun je beter de for-loop gebruiken

        // statement 1: Declaratie en initialisatie van de loop variable.
        // statement 2: Conditie check. Blijf loopen zolang de conditie true is.
        // statement 3: Verhoging van de loop variabele.
        //int xx = 0;
        for (int xx = 0; xx < 10; xx++)
        {
            Console.WriteLine($"De loop variabele xx = {xx}");
        }
        //Console.WriteLine($"xx={xx}");
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
