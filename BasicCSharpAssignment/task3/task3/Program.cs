using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Ask the user for the first integer
                Console.Write("Enter the first integer: ");
                int num1 = int.Parse(Console.ReadLine());

                // Ask the user for the second integer
                Console.Write("Enter the second integer: ");
                int num2 = int.Parse(Console.ReadLine());

                // Perform addition
                int sum = num1 + num2;
                Console.WriteLine($"Addition: {num1} + {num2} = {sum}");

                // Perform subtraction
                int difference = num1 - num2;
                Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");

                // Perform multiplication
                int product = num1 * num2;
                Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

                // Perform division (handle division by zero separately)
                if (num2 != 0)
                {
                    double quotient = (double)num1 / num2;
                    Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }

                // Perform modulus (remainder after division)
                if (num2 != 0)
                {
                    int remainder = num1 % num2;
                    Console.WriteLine($"Modulus: {num1} % {num2} = {remainder}");
                }
                else
                {
                    Console.WriteLine("Modulus by zero is not allowed.");
                }
            
        }

    }
}

