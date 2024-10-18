namespace LastigereObjecten;

internal class Program
{
    static void Main(string[] args)
    {
       // Lamp l1 = new Lamp { Kleur = "paars", Sterkte = 300 };
        //l1.Aan();
        //l1.Uit();

        Lamp tl1 = new TL { Kleur = "zwart", Sterkte = 200, StartTijd = 5 };
        tl1.Aan();
        tl1.Uit();

        // Ik maak een nieuw TL object en beschouw hem als Lamp.
        // Dit is nu Generaliseren.
        Lamp tl2 = new TL { Kleur = "groen", Sterkte = 700, StartTijd = 3 };
        tl2.Aan();
        BouwLamp l3 = new BouwLamp { Sterkte = 1200, Kleur = "wit" };
        l3.Aan();

        SteekLampAan(l3);
        SteekLampAan(tl1);
        
    }

    static void SteekLampAan(Lamp lamp)
    {
        lamp.Aan();
        lamp.Uit();
    }
    //static void SteekLampAan(BouwLamp lamp)
    //{
    //    lamp.Aan();
    //}
}
