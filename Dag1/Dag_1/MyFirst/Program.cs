using System;
class Program
{
    static void Main()
    {
        // Hier begint het programma
        // De declarative van de variabele leeftijd van het type byte.
        // De toekenning van het getal 42 (literal) noemt men de initialisatie.
        // Typenaam variabelenaam = literal of andere variabele.
        string name = "Patrick"; // Literal Patrick
        char first = 'P'; // Literal P
        bool isMale = true; // Literal true
        byte leeftijd = 42; // Literal 42
        byte age = leeftijd; // leeftijd is GEEN Literal
        leeftijd = 43;
        Console.Write("Het getal is: ");
        Console.WriteLine(leeftijd);
        string userInput;
        userInput = Console.ReadLine();
        Console.WriteLine(userInput);

    }
}

