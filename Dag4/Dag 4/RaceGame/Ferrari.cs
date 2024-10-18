namespace RaceGame
{
    internal class Ferrari: Auto
    {
        public override void GasGeven()
        {
            Console.WriteLine("De Ferrari begint te brullen");
            base.GasGeven();
        }
        public Ferrari()
        {
            MaxSnelheid = 300;
        }
    }
}
