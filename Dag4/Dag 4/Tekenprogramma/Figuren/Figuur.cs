using Tekenprogramma.Shared;

namespace Tekenprogramma.Figuren;

internal class Figuur
{
    public Coordinaat Position { get; set; }
    public string Kleur { get; set; }

    public virtual void Teken()
    {
        Console.WriteLine($"Positie: {Position}, Kleur: {Kleur}");
    }
}
