namespace ArrayOefening;

internal class Program
{
    static void Main(string[] args)
    {
        //int nr = Random.Shared.Next(1, 11);
        // Type naam;
        int[] nummers = new int[20];

        for (int i = 0; i < 20; i++)
        {
            nummers[i] = Random.Shared.Next(1, 1100);
        }

        foreach (int getal in nummers)
        {
            Console.WriteLine(getal);
        }
    }
}
