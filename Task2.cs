using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCS
{
    class Task2
    {
        /*
         * Task 2:
         * Write a C# program that prints the sum of odd and even numbers from 1 to 1000.
         * 
         * Sums of numbers between 1 and 1000.
         * Odd: 250000
         * Even: 250500
         */
        static void Main(string[] args)
        {
            // Initialize the sums and set them to zero.
            int oddSum = 0;
            int evenSum = 0;

            // Go through ALL numbers between 1 and 1000.
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0) // If number is even
                {
                    evenSum += i;
                } else // Otherwise, if it is odd
                {
                    oddSum += i;
                }
            }

            // Print out the results
            Console.WriteLine("Sums of numbers between 1 and 1000.");
            Console.WriteLine("Odd: " + oddSum);
            Console.WriteLine("Even: " + evenSum);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }


    }
}
