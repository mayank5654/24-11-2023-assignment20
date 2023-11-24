using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{

    class AgeCategoryProgram
    {
        static void Main(string[] args)
        {


            {

                int age;

                // Keep prompting the user until a valid age is entered
                do
                {
                    Console.Write("Enter your age: ");
                    string input = Console.ReadLine();

                    // Try parsing the input to an integer
                    if (int.TryParse(input, out age))
                    {
                        // Age is a valid integer
                        break;
                    }
                    else
                    {
                        // Display an error message for invalid input
                        Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                    }
                } while (true);

                // Determine the age category and display a message
                if (age < 0)
                {
                    Console.WriteLine("Invalid age. Please enter a non-negative integer.");
                }
                else if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                }
            }
        }
        

    }
}

