namespace JumpForward;

internal class Program
{
    static void Main(string[] args)
    {
        int teRadenGetal = Random.Shared.Next(0, 6);
        Console.WriteLine(teRadenGetal);

        // Je test op concrete waarden. In dit geval is het netter om een switch te gebuiken
        //if (teRadenGetal == 0)
        //{
        //    Console.WriteLine("Hé. Een 0");
        //}
        //else if (teRadenGetal == 1)
        //{
        //    Console.WriteLine("Hé. Een 1");
        //}
        //else if (teRadenGetal == 2)
        //{
        //    Console.WriteLine("Hé. Een 2");
        //}
        //else if (teRadenGetal == 3)
        //{
        //    Console.WriteLine("Hé. Een 3");
        //}
        //else if (teRadenGetal == 4)
        //{
        //    Console.WriteLine("Hé. Een 4");
        //}
        //else
        //{
        //    Console.WriteLine("Jammer. Iets anders");
        //}

        switch (teRadenGetal)
        {
            case 0:
                Console.WriteLine("Hé. Een 0");
                break;
            case 1:
                Console.WriteLine("Hé. Een 1");
                break;
            case 2:
                Console.WriteLine("Hé. Een 2");
                break;
            case 3:
                Console.WriteLine("Hé. Een 3");
                break;
            case 4:
                Console.WriteLine("Hé. Een 4");
                break;
            default:
                Console.WriteLine("Jammer. Iets anders");
                break;
        }


        //Console.Write("Geef een getal: ");
        //string inp = Console.ReadLine();
        //int getal = int.Parse(inp);


        //// Jump forward als conditie (getal > teRadenGetal) false is
        //if (getal > teRadenGetal)
        //{
        //    Console.WriteLine("Uw gegeven getal is groter dan het te raden getal");
        //}
        //else if(getal < teRadenGetal)
        //{
        //    Console.WriteLine("Uw gegeven getal is kleiner dan het te raden getal");
        //}
        //else
        //{
        //    Console.WriteLine("Uw gegeven getal is gelijk aan het te raden getal");
        //}

        Console.WriteLine("En we gaan door");
    }
}
