namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {
        byte x = 10;
        byte y = x;

        // Hier kom ik mee weg want een byte past in een short.
        // Implicit casting
        short z = x;
        int a = z;

        long b = 1_000_000_000_000;

        // Explixit casting. Hierbij kun je data verliezen
        a = (int)b;
        decimal c = 23.123456789123456789123456789M;
        long d = (long)c;
        // Deze vorm van casting werkt alleen bij compatible types.
        Console.WriteLine(d);
        int h;
        //Console.WriteLine(h);
        // String is niet compatible met ints e.d. dus moet er geparsed worden.
        string number = "10";
        int e = int.Parse(number);
        string andergetal = e.ToString();
        Console.WriteLine(andergetal);

        char f = (char)80;// (char)176;
        Console.WriteLine(f);

        const double PI = 3.14243567;
        Console.WriteLine(PI);



    }
}
