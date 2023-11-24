using System;

class FactorialProgram
{
    static void Main()
    {
        // Prompt the user to enter an integer
        Console.Write("Enter a positive integer: ");
        int userInput = int.Parse(Console.ReadLine());

        // Check if the input is a positive integer
        if (userInput >= 0)
        {
            // Call the CalculateFactorial method and display the result
            long factorialResult = CalculateFactorial(userInput);
            Console.WriteLine($"Factorial of {userInput} is: {factorialResult}");
        }
        else
        {
            Console.WriteLine("Please enter a non-negative integer.");
        }
    }

    // Recursive method to calculate the factorial of a given positive integer
    static long CalculateFactorial(int n)
    {
        // Base case: factorial of 0 is 1
        if (n == 0)
        {
            return 1;
        }

        // Recursive case: n! = n * (n-1)!
        return n * CalculateFactorial(n - 1);
    }
}
