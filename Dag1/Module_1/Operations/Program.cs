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
        //int result;
        //result = 3 + a; // Geneste expressie

        //Console.WriteLine(result);

        // Rekenkundige operatoren
        //++a;   // a = a + 1
        //a += 4;  // a = a + 4
        Console.WriteLine(++a);
        Console.WriteLine(a);

        // Vergelijkingsoperatoren
        // Komt altijd een boolean uit (waar of niet waar)
        int x = 10;
        int y = 20;

        bool isgelijk = x == y;
        Console.WriteLine(isgelijk);
        bool isOngelijk = x != y;
        Console.WriteLine(isOngelijk);
        bool result = x > y;
        Console.WriteLine(result);
        result = x < y; 
        result = x >= y;
        result = x <= y;

        // Logische operatoren
        // Binaire operatoren waarbij de operands altijd een boolean moet zijn.

        // Waarheidstabel AND (&&)
        // | p     | q     | result
        // | true | true | true
        // | true | false| false
        // | false| true | false
        // | false| false| false

        // Waarheidstabel OR (||)
        // | p     | q     | result
        // | true | true | true
        // | true | false| true
        // | false| true | true
        // | false| false| false

        // Waarheidstabel XOR (^)
        // | p     | q     | result
        // | true | true | false
        // | true | false| true
        // | false| true | true
        // | false| false| false


        bool p = true;
        bool q = false;

        result = p && q;
        Console.WriteLine(result);

        result = p || q;
        Console.WriteLine(result);

    }
}
