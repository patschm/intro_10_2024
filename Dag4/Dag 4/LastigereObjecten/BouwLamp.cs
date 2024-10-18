

namespace LastigereObjecten
{
    internal class BouwLamp : Lamp
    {
        public override void Aan()
        {
             Console.WriteLine($"De Bouwlamp brandt in het {Kleur} met intensiteit {Sterkte}lm");
        }
        public override void Uit()
        {
            Console.WriteLine("De Bouwlamp is nu uit");
        }
    }
}
