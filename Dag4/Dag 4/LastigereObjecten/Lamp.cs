

namespace LastigereObjecten
{
    internal class Lamp
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

        // Met virtual geef ik aan dat dit gedraga polymorf KAN zijn.
        // Een afgeleide class kan besluiten het gedrag polymorf te maken.
        public virtual void Aan()
        {
            Console.WriteLine($"De lamp brandt in het {Kleur} met intensiteit {Sterkte}lm");
        }
        public void Uit()
        {
            Console.WriteLine("De lamp is nu uit");
        }
    }
}
