using System;

namespace Calculator_CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables and then initialize
            int num1 = 0;
            int num2 = 0;

            // decoration
            Console.WriteLine("CLI Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to type the first number and get the input
            Console.WriteLine("Type your first number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to type another number and get the input
            Console.WriteLine("Type your second number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Ask for the operation with a switch statement
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait befor the user close the calculator
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
