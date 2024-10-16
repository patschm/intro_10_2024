
namespace Calculator;

internal class ProgramStructured
{
    static void Main(string[] args)
    {
        do
        {
            int aaa = AskNumber("A");
            int b = AskNumber("B");        
            string operation = AskForOperation();
            DoCalculation(aaa,b, operation);
        }
        while (CanContinue());
    }

    static bool IsValidOperation(string operation)
    {
        return operation == "*" || operation == "/" || operation == "+" || operation == "-" || operation=="%";
    }
    static int AskNumber(string label)
    {
        int b;
        do
        {
            Console.Write($"Geef getal {label}: ");
            string sB = Console.ReadLine();
            if (int.TryParse(sB, out b)) break;
            Console.WriteLine("Ongeldige invoer");
        }
        while (true);
        return b;
    }
    static void DoCalculation(int a, int b, string operation)
    {
        switch (operation)
        {
            case "+":
                DoAdd(a,b); 
                break;
            case "-":
                DoSubtract(a,b);
                break;
            case "*":
                DoMultiply(a,b);
                break;
            case "/":
                DoDivide(a,b);
                break;
            case "%":
                DoModulus(a,b);
                break;
            default:
                Console.WriteLine($"De operatie {operation} is mij niet bekend.");
                break;
        }
    }
    static bool CanContinue()
    {
        Console.WriteLine("Wilt U nog een berekening doen? (ESC voor nee. Elke andere toets voor ja)");
        ConsoleKeyInfo key = Console.ReadKey();
        return key.Key != ConsoleKey.Escape;
    }
    static string AskForOperation()
    {
        string operation;
        do
        {
            Console.WriteLine("Welke operatie? Kies uit +, -, *, / of %");
            operation = Console.ReadLine();
        }
        while (IsValidOperation(operation));

        return operation;
    }
    static void DoAdd(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"{a} + {b} = {result}");
    }
    static void DoSubtract(int a, int b)
    {
        int result = a - b;
        Console.WriteLine($"{a} - {b} = {result}");
    }
    static void DoMultiply(int a, int b)
    {
        int result = a * b;
        Console.WriteLine($"{a}  * {b} = {result}");
    }
    static void DoDivide(int a, int b)
    {
        double result = a / (double)b;
        Console.WriteLine($"{a} / {b} = {result}");
    }
    static void DoModulus(int a, int b)
    {
        int result = a % b;
        Console.WriteLine($"{a} % {b} = {result}");
    }
}

