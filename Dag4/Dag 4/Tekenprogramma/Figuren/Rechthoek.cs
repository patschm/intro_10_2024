namespace Tekenprogramma.Figuren;

internal class Rechthoek: Figuur
{
    public int Hoogte { get; set; }
    public int Breedte { get; set; }

    public override void Teken()
    {
        Console.Write($"Rechthoek met hoogte: {Hoogte} en breedte: {Breedte}. ");
        base.Teken();
    }
}
