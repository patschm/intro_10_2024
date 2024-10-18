
namespace LastigereObjecten
{
    // De TL Erft van de Lamp.
    // Hij krijgt hierdoor alle eigenschappen en gedrag van de lamp
    // Je mag maar van één class tegelijk erven.
    // Ik mag wèl van TL erven
    // Hergebruik is een belangrijk voordeel (DRY)
    // !!! Bij overerving moet je altijd de vraag kunnen stellen: Is het een
    // Als een class sealed is, kun je er niet meer vaan erven.
    sealed class TL : Lamp
    {
        public int StartTijd { get; set; } = 4;

        // Met override geef ik aan dat dit gedrag polymorf is.
        public override void Aan()
        {
            Console.WriteLine($"De TL knippert {StartTijd} seconde");
            Console.WriteLine($"De TL brandt in het {Kleur} met intensiteit {Sterkte}lm");
        }
        public override void Uit()
        {
            Console.WriteLine("De TL is nu uit");
        }
    }
}
