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
        try
        {
            Console.WriteLine("\nPlease Input operand One:");
            op1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease Input operand Two:");
            op2 = Double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number given!");
            return;
        }
        finally { 
        }
        try
        {
            switch (op)
            {
                case '+':
                    Console.WriteLine("The result is " + (op2 + op1));
                    break;
                case '/':
                    
                    Console.WriteLine("The result is " + (op1 / op2));
                    break;
                case '*':
                    Console.WriteLine("The result is " + (op2 * op1));
                    break;
                case '-':
                    Console.WriteLine("The result is " + (op1 - op2));
                    break;



            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Cannot divide by zero");

        }
        finally
        {
            Console.WriteLine("GoodBye");
        }

    }

}
