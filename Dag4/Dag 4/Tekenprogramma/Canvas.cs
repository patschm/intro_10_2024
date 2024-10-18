using Tekenprogramma.Figuren;

namespace Tekenprogramma;

internal class Canvas
{
    private List<Figuur> figuren = new List<Figuur>();

    public void VoegTo(Figuur figuur)
    {
        figuren.Add(figuur);
    }

    public void Ververs()
    {
        Console.Clear();
        foreach(Figuur figure in figuren)
        {
            figure.Teken();
        }
    }
}
