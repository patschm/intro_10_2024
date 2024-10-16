namespace Calculator;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            int a;
            int b;
            bool isOk = false;
            do
            {
                Console.Write("Geef getal A: ");
                string sA = Console.ReadLine();
                isOk = int.TryParse(sA, out a);
                if (!isOk)
                {
                    Console.WriteLine("Ongeldige invoer");
                }
                else
                {
                    break;
                }
            }
            while (!isOk);

            do
            {
                Console.Write("Geef getal B: ");
                string sB = Console.ReadLine();
                if (int.TryParse(sB, out b)) break;
                Console.WriteLine("Ongeldige invoer");
            }
            while (true);


            Console.WriteLine("Welke operatie? Kies uit +, -, *, / of %");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    int resop = a + b;
                    Console.WriteLine($"{a} + {b} = {resop}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b} = {a / (double)b}");
                    break;
                case "%":
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
            }
            Console.WriteLine("Wilt U nog een berekening doen? (ESC voor nee. Elke andere toets voor ja)");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape) break;
        }
        while (true);
    }
    //int resop = a + b;
    //Console.WriteLine($"{a} + {b} = {resop}");
    //int resaf = a - b;
    //Console.WriteLine($"{a} - {b} = {resaf}");
    //int resve = a * b;
    //Console.WriteLine($"{a} * {b} = {resve}");
    //double ressu = a / (double)b;
    //Console.WriteLine($"{a} / {b} = {ressu}");
    //int resmo = a % b;
    //Console.WriteLine($"{a} % {b} = {resmo}");
}

