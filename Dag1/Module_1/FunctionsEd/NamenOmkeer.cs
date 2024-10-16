
namespace FunctionsEd;

internal class NamenOmkeer
{
    /// <summary>
    /// Deze procedure geeft een welkomsbericht
    /// </summary>
    public static void ToonWelkomsBericht()
    {
        Console.WriteLine("Goedendag beste gebruiker.");
        Console.WriteLine("Het is de bedoeling dat u uw naam opgeeft en dat wij die omdraaien");
    }

    /// <summary>
    /// Deze functie toont een afscheidsbericht
    /// </summary>
    /// <param name="naam">De naam van de speler</param>
    public static void ToonAfscheidsBericht(string naam)
    {
        Console.WriteLine("That's all Folks!");
        Console.WriteLine($"Tot ziens {naam}");
    }


    // Procedure
    public static void ToonOmgekeerdeNaam(string naam)
    {
        Console.WriteLine($"De omgekeerde naam is: {naam}");
    }

    // Function
    public static string GeefUwNaam()
    {
        Console.Write("Geef uw naam: ");
        // Lokale variabele bliep. Kun je van buiten niet bij.
        string bliep = Console.ReadLine();
        return bliep;
    }

    /// <summary>
    /// Deze functie keert de naam om (achterstevoren)
    /// <code>
    /// string reverse = NamenOmkeer.DraaiDeNaamOm("Jan");
    /// </code>
    /// </summary>
    /// <param name="name">De naam die omgekeerd moet worden</param>
    /// <returns>De omgekeerde naam</returns>
    public static string DraaiDeNaamOm(string name)
    {
        // Lokale variabele tmp
        char[] tmp = name.ToCharArray();
        Array.Reverse(tmp);
        string reverse = new string(tmp);
        return reverse;
    }
}
