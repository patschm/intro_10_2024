using Tekenprogramma.Figuren;
using Tekenprogramma.Shared;

namespace Tekenprogramma;

internal class Program
{
    static void Main(string[] args)
    {
       Canvas canvas = new Canvas();
        canvas.VoegTo(CreateCirkel("rood"));
        canvas.VoegTo(CreateCirkel("groen"));
        canvas.VoegTo(CreateCirkel("blauw"));

        canvas.VoegTo(CreateDriehoek("rood"));
        canvas.VoegTo(CreateDriehoek("groen"));
        canvas.VoegTo(CreateDriehoek("blauw"));

        canvas.VoegTo(CreateRechthoek("rood"));
        canvas.VoegTo(CreateRechthoek("groen"));
        canvas.VoegTo(CreateRechthoek("blauw"));

        canvas.Ververs();
    }

    static Cirkel CreateCirkel(string kleur, int straal = 100)
    {
        return new Cirkel
        {
            Kleur = kleur,
            Straal = straal,
            Position = RandomPosition()
        };
    }
    static Rechthoek CreateRechthoek(string kleur, int hoogte = 100, int breedte=70)
    {
        return new Rechthoek
        {
            Kleur = kleur,
            Breedte = breedte,
            Hoogte = hoogte,
            Position = RandomPosition()
        };
    }
    static Driehoek CreateDriehoek(string kleur, int hoogte = 70, int basis = 150, int hoek=60)
    {
        return new Driehoek
        {
            Kleur = kleur,
            Basis = basis,
            Hoek = hoek,
            Hoogte = hoogte,
            Position = RandomPosition()
        };
    }

    static Coordinaat RandomPosition()
    {
        return new Coordinaat
        {
            X = Random.Shared.Next(10, 500),
            Y = Random.Shared.Next(10, 600)
        };
    }
}
