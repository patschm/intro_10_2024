
namespace RaceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto car1 = new Auto("rood");
            //car1.Kleur = "rood";

            Auto car2 = new Auto("groen");
           // car2.Kleur = "groen";

            //car1.GasGeven();
            //car1.GasGeven();

            //car2.GasGeven();
            //car1.GasGeven();

            //car2.Remmen();
            //car1.LinksAf();
            //car2.RechtsAf();

            Control(car2);

        }
        static void Control(Auto car)
        {
            do
            {
                ConsoleKey key = Console.ReadKey().Key;
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        car.LinksAf();
                        break;
                    case ConsoleKey.RightArrow:
                        car.RechtsAf();
                        break;
                    case ConsoleKey.UpArrow:
                        car.GasGeven();
                        break;
                    case ConsoleKey.DownArrow:
                        car.Remmen();
                        break;
                }
            }
            while (true);
        }
    }


}
