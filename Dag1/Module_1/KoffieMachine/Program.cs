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
        Console.WriteLine("Wilt u suiker erin? (Y/N)");
        string sOk = Console.ReadLine();
        bool withSugar = sOk == "Y" || sOk == "y";
        byte hoeveelheidSuiker = 0;
        if (withSugar == true)
        {
            Console.WriteLine("Hoeveel suiker? (1 klontje, 2 klontjes, 3 klontjes)");
            string sHoeveel = Console.ReadLine();
            hoeveelheidSuiker = byte.Parse(sHoeveel);
        }
        Console.WriteLine("Wilt u melk erin? (Y/N)");
        sOk = Console.ReadLine();
        bool withMilk = sOk == "Y" || sOk=="y";
        byte hoeveelheidMelk = 0;
        if (withMilk)
        {
            Console.WriteLine("Hoeveel melk wilt u erin? (1 is weinig 2 is normaal en 3 is veel)");
            string sMelk = Console.ReadLine();
            hoeveelheidMelk = byte.Parse(sMelk);
        }

        Console.Write($"Uw keuze is {drank} {hoeveelheid}ml");
        if (withSugar)
        {
            if (hoeveelheidSuiker == 1)
            {
                Console.Write($" met {hoeveelheidSuiker} klontje suiker");
            }
            else
            {
                Console.Write($" met {hoeveelheidSuiker} klontjes suiker");
            }
        }
        if (withMilk )
        {
            Console.Write($" en {hoeveelheidMelk} melk");
        }
        Console.WriteLine();
       //Console.Write("\r\n");
        Console.WriteLine("En verder");
    }
}
