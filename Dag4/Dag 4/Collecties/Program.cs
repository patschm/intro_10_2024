
namespace Collecties;

internal class Program
{
    static void Main(string[] args)
    {
        //DemoArray();
        //int[] nummers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int res =  HetProbleem(nummers);
        //Console.WriteLine(res);
        DemoList();
    }

    private static void DemoList()
    {
        // List is handig in de zin dat de lijst dynamisch uitbreidbaar is.
        List<string> hotels = new List<string>();
        List<int> restaurants = new List<int>();
        List<DateTime> zonnen = new List<DateTime>();  
        List<Fietsbel> bellen = new List<Fietsbel>();

        hotels.Add("Hello");
        hotels.Add("World");
        hotels.Add("!");
        hotels[2] = "!!!!!!";
        Console.WriteLine(hotels[1]);
        ShowList(hotels);
    }

    static void ShowList(List<string> list)
    {
        foreach (string element in list)
        {
            Console.WriteLine(element);
        }
    }

    static void DemoArray()
    {
        // Array is een collectie
        // Kenmerken:
        //   - aaneengesloten (slaat op het geheugenblok)
        //   - immutable (slaat op het geheugenblok)
        //   - alle data zijn van hetzelfde type
        //  Type[] naam = new Type[10];
        //  Type[]  === de typenaam

        int[] nummers = new int[7];
        nummers[0] =1;
        nummers[1] =2;
        nummers[2] =3;
        nummers[3] = 15;
        nummers[4] = 20;
        nummers[5] = 30;
        nummers[6] = 31;

        Console.WriteLine(nummers.Length);
        for(int i =0; i < nummers.Length; i++)
        {
            int tmp = nummers[i];
            Console.WriteLine(tmp);
        }

        foreach(int tmp in nummers)
        {
            Console.WriteLine(tmp);
        }


        //Console.WriteLine(nummers[0]);
        //Console.WriteLine(nummers[1]);
        //Console.WriteLine(nummers[2]);
        //Console.WriteLine(nummers[3]);
        //Console.WriteLine(nummers[4]);


        string[] violen = new string[3];
        violen[2] = "klaar";
        violen[0] = "Hallo";
        violen[1] = "World";

        foreach(string tmp in violen)
        {
            Console.WriteLine(tmp);
        }

        for(int i = 0; i < violen.Length; i++)
        {
            string tmp = violen[i];
            Console.WriteLine(tmp);
        }

        Console.WriteLine(violen[2] );


        //decimal[] bamiballen = new decimal[13];
        //DateTime[] zon = new DateTime[8];
        //Fietsbel[] fietsbellen = new Fietsbel[8];
        //char[] tekenreeks = new char[8];

    }

    static int HetProbleem(int[] nummers)
    {
        return nummers.Sum();
    }
}
