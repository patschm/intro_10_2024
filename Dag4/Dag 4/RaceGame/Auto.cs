namespace RaceGame
{
    class Auto
    {
        private int snelheid = 0;
        protected int MaxSnelheid = 300;

        public Auto()
        {
            
        }
        public Auto(string kleur)
        {
            Kleur = kleur;
        }

        public int Snelheid
        {
            get
            {
                return snelheid;
            }
            set
            {
                if (value >= 0 && value <= MaxSnelheid)
                {
                    snelheid = value;
                }
            }
        }
        public string Kleur { get; set; }

        public virtual void GasGeven()
        {
            Snelheid += 10;
            Console.WriteLine($"de {Kleur} auto versnelt nu tot {Snelheid}km/u");
        }
        public void Remmen()
        {
            Snelheid -= 10;
            if (Snelheid > 0)
                Console.WriteLine($"de {Kleur} auto vertraagt nu tot {Snelheid}km/u");
            else
                Console.WriteLine($"de {Kleur} auto staat stil");
        }
        public void LinksAf()
        {
            Console.WriteLine($"de {Kleur} auto gaat linksaf");
        }
        public void RechtsAf()
        {
            Console.WriteLine($"de {Kleur} auto gaat rechtsaf");
        }
    }
}
