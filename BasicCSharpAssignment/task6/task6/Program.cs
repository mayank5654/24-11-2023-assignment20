using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class ArraySumAverageProgram
    {
        static void Main(string[] args)
        {

        
           
                // Declare and initialize an integer array with five elements
                int[] numbers = { 15, 22, 330, 420, 560 };

                // Calculate the sum of the elements
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum += number;
                }

                // Calculate the average of the elements
                double average = (double)sum / numbers.Length;

                // Display the sum and average on the console
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");

                // Uncomment the line below if you want to keep the console window open
                // Console.ReadLine();
            
        }

    }
}

