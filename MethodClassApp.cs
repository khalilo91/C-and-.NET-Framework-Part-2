using System;   // Imports base .NET functionality, like Console

namespace MethodClassAssignment
{
    // Create a class called MathOperations
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void DoMath(int number1, int number2)
        {
            // Perform a math operation on the first integer
            int result = number1 * 2;   // Multiply number1 by 2

            // Display the result and the second integer
            Console.WriteLine("The result of the math operation on the first number is: " + result);
            Console.WriteLine("The second number is: " + number2);
        }
    }

    // Main program class
    class Program
    {
        // The entry point of the program
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOp = new MathOperations();

            // Call the method and pass two numbers directly
            mathOp.DoMath(5, 10);

            // Call the method again, specifying the parameters by name
            mathOp.DoMath(number1: 7, number2: 20);

            // Keep the console open until a key is pressed
            Console.ReadLine();
        }
    }
}
