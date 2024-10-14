namespace KoffieMachine;

internal class Program
{
    static void Main(string[] args)
    {
        const short SMALL = 100;
        const short MEDIUM = 300;
        const short LARGE = 500;

        const byte MELK_SMALL = 10;
        const byte MELK_MEDIUM = 20;
        const byte MELK_LARGE = 30;

        const byte SUIKER_SMALL = 1;
        const byte SUIKER_MEDIUM = 2;
        const byte SUIKER_LARGE = 3;

        Console.WriteLine("Hallo");
        Console.WriteLine("Wilt u koffie, thee of water?");
        string drank = Console.ReadLine();
        Console.WriteLine($"Welk formaat? ({SMALL}ml, {MEDIUM}ml or {LARGE}ml)");
        string hoeveelheid = Console.ReadLine();
        Console.WriteLine("Wilt u hierin suiker? (0 is geen, 1 is weinig 2 is normaal en 3 is veel)");
        string sSuiker = Console.ReadLine();
        byte hoeveelheidSuiker = byte.Parse(sSuiker);
        // Of substitutie principe toepassen:
        //byte hoeveelheidSuiker = byte.Parse(Console.ReadLine());
        Console.WriteLine("Wilt u hierin melk? (0 is geen, 1 is weinig 2 is normaal en 3 is veel)");
        string sMelk = Console.ReadLine();
        byte hoeveelheidMelk = byte.Parse(sMelk);

        Console.WriteLine($"Uw keuze is {drank} {hoeveelheid} met {hoeveelheidSuiker} suiker en {hoeveelheidMelk} melk");
        //Console.Write("Uw keuze is: ");
        //Console.Write(drank);
        //Console.Write(" met ");
        //Console.Write(hoeveelheidSuiker);
        //Console.Write(" suiker en ");
        //Console.Write(hoeveelheidMelk);
        //Console.WriteLine(" melk");
    }
}
