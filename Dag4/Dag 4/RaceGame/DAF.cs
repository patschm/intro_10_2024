namespace RaceGame
{
    internal class DAF: Auto
    {
        public override void GasGeven()
        {
            Console.WriteLine("De DAF begint te zoemen");
            // base verwijst naar zijn directe parent
            base.GasGeven();
            // this verwijst naar zichzelf
            // Lees this als IK (of Me in VB.NET)
            //this.GasGeven();
        }
        public DAF()
        {
            MaxSnelheid = 100;
        }
    }
}
