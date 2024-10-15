namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Geef getal A: ");
        string sA = Console.ReadLine();
        int a = int.Parse(sA);
        Console.Write("Geef getal B: ");
        string sB = Console.ReadLine();
        int b = int.Parse(sB);

        int resop = a + b;
        Console.WriteLine($"{a} + {b} = {resop}");
        int resaf = a - b;
        Console.WriteLine($"{a} - {b} = {resaf}");
        int resve = a * b;
        Console.WriteLine($"{a} * {b} = {resve}");
        double ressu = a / (double)b;
        Console.WriteLine($"{a} / {b} = {ressu}");
        int resmo = a % b;
        Console.WriteLine($"{a} % {b} = {resmo}");
    }
}
