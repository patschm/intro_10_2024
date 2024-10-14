namespace Operations;

internal class Program
{
    static void Main(string[] args)
    {
        // Een expressie is een uitrdukking
        // waarin een OPERATOR werkt op 1 of meer OPERANDS
        // Een operand kan zijn een variabele, constante of literal.
        // Een operator doet iets met operands.
        // Denk bijvoorbeeld aan opteloperator, aftrekoperator, vermenigvuldigoperator.
        // (+, -, *, /)
        // Drie groepen:
        // 1) Unaire. Die werken op 1 operand.
        // 2) Binaire. Werken op 2 operands.
        // 3) Ternaire. Werken op 3 operands.
        // VB expressie: 3 + 4; 3 en 4 zijn de operands en + is de operator.

        int a = 9;
        //int b = 3;
        int result;
        result = 3 + a; // Geneste expressie

        Console.WriteLine(result);

        //++a;   // a = a + 1
        Console.WriteLine(++a);
        Console.WriteLine(a);


    }
}
