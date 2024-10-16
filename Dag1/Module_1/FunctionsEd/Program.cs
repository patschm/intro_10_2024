namespace FunctionsEd;

internal class Program
{
    static void Main(string[] args)
    {
        ToonWelkomsBericht();
        string naam = GeefUwNaam();    
        string omgedraaideNaam = DraaiDeNaamOm(naam);
        ToonOmgedraaideNaam(omgedraaideNaam);
        ToonAfscheidsBericht(naam);

        NamenOmkeer.ToonWelkomsBericht();
        naam = NamenOmkeer.GeefUwNaam();
        omgedraaideNaam = NamenOmkeer.DraaiDeNaamOm(naam);
        NamenOmkeer.ToonOmgekeerdeNaam(omgedraaideNaam);
        NamenOmkeer.ToonAfscheidsBericht(naam);

    }

    // Procedure
    static void ToonWelkomsBericht()
    {
        Console.WriteLine("Goedendag beste gebruiker.");
        Console.WriteLine("Het is de bedoeling dat u uw naam opgeeft en dat wij die omdraaien");
    }

    // Procedure
    static void ToonAfscheidsBericht(string tmp3)
    {
        Console.WriteLine("That's all Folks!");
        Console.WriteLine($"Tot ziens {tmp3}");
    }


    // Procedure
    static void ToonOmgedraaideNaam(string tmp2)
    {
        Console.WriteLine($"De omgekeerde naam is: {tmp2}");
    }

    // Function
    static string GeefUwNaam()
    {
        Console.Write("Geef uw naam: ");
        // Lokale variabele bliep. Kun je van buiten niet bij.
        string bliep = Console.ReadLine();
        return bliep;
    }

    // Function. Argument van type string
    static string DraaiDeNaamOm(string name)
    {
        // Lokale variabele tmp
        char[] tmp = name.ToCharArray();
        Array.Reverse(tmp);
        string tmp2 = new string(tmp);
        return tmp2;
    }
}
