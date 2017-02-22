using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCS
{
    class Task1
    {
        /*
         * Task 1:
         * Write a C# program that takes N as input and then prints out the 
         *  x∈[1,N] numbers from the f(x)=x^2 sequence.
         * N: 10
         * Sequence: 1 4 9 16 25 36 49 64 81 100
         */
        static void Main(string[] args)
        {
            // Let the user type in the value of N
            Console.Write("N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Print the sequence
            Console.Write("Sequence: ");
            for (int i = 1; i <= N; i++)
            {
                Console.Write(i * i + " ");
            }

            // Stop the console from exiting immediately
            Console.ReadLine();
        }


    }
}
