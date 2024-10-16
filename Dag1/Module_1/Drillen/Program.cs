namespace Drillen;

internal class Program
{
    static void Main(string[] args)
    {
        //SayHello();
        //SayHello("Patrick");
        //SayHello("Patrick", 7);
        //double result = GetPI();
        double result = GetVeelvoudPI(3);
        Console.WriteLine(result);
    }

    static void SayHello()
    {
        Console.WriteLine("Hello");
    }
    static void SayHello(string naam)
    {
        Console.WriteLine($"Hello {naam}");
    }
    static void SayHello(string naam, int repeat)
    {
        for(int i = 0; i < repeat; i++)
        {
            Console.WriteLine($"Hello {naam}");
        }
    }
    static double GetPI()
    {
        return 3.1424;
    }
    static double GetVeelvoudPI(int maal)
    {
        return 3.1424 * maal;
        //return maal * GetPI();
    }
}
