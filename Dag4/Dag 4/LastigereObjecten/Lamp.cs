namespace LastigereObjecten
{
    // Het keyword abstract voorkomt dat je instanties (objecten)
    // kunt maken van deze class.
    // Je kunt hem alleen nog gebruiken voor generaliseren.
    abstract class Lamp
    {
        private int sterkte = 0;

        public int Sterkte
        {
            get
            {
                return sterkte;
            }
            set
            {
                if (value >= 0)
                {
                    sterkte = value;
                }
            }
        }
        public string Kleur { get; set; }

        // Met virtual geef ik aan dat dit gedrag polymorf KAN zijn.
        // Een afgeleide class kan besluiten het gedrag polymorf te maken.
        // Is dus optioneel (vrijblijvend)
        public virtual void Aan()
        {
            Console.WriteLine($"De lamp brandt in het {Kleur} met intensiteit {Sterkte}lm");
        }
        // Met abstract wordt polymorfisme afgedwongen.
        // De afgeleide class MOET nu de methode overriden.
        // Het is niet langer vrijblijvend.
        // De body (implementatie) van de methode moet dan ook weg.
        // En dat heeft ook weer gevolgen:
        public abstract void Uit();
        //{
        //    Console.WriteLine("De lamp is nu uit");
        //}
    }
}
