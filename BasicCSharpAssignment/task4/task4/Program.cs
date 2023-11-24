using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                // Ask the user to enter an integer
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                // Check if the number is even or odd using if-else statements
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }
        

    }
}

