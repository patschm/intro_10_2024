namespace RaceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto car1 = new Auto();
            car1.kleur = "rood";

            Auto car2 = new Auto();
            car2.kleur = "groen";

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

    class Auto
    {
        public int snelheid = 0;
        public string kleur;

        public void GasGeven()
        {
            snelheid += 10;
            Console.WriteLine($"de {kleur} auto versnelt nu tot {snelheid}km/u");
        }
        public void Remmen()
        {
            snelheid -= 10;
            Console.WriteLine($"de {kleur} auto vertraagt nu tot {snelheid}km/u");
        }
        public void LinksAf()
        {
            Console.WriteLine($"de {kleur} auto gaat linksaf");
        }
        public void RechtsAf()
        {
            Console.WriteLine($"de {kleur} auto gaat rechtsaf");
        }
    }
}
