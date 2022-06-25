using System;
class Program { 
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, Please choose an Operation: * + /  -");
        char op = Console.ReadLine()[0];

        if(op != '*' && op != '+' && op != '/' && op != '-')
        {
            Console.Error.WriteLine("Error invalid operation\nTry Again");
            Program.Main(null);
        }
        double op1, op2;

        Console.WriteLine("\nPlease Input operand One:");
        Console.WriteLine("\nPlease Input operand Two:");

        switch (op) { }

    }

}
