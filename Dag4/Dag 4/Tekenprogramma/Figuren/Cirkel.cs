namespace Tekenprogramma.Figuren;

internal class Cirkel : Figuur
{
    public int Straal { get; set; }

    public override void Teken()
    {
        Console.Write($"Cirkel met straal: {Straal}. ");
        base.Teken();
    }
}
