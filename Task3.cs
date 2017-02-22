using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCS
{
    class Task3
    {
        /*
         * Task 3:
         * Write a C# program that contains a function in which an array of 
         *  integers is passed. Fill that array with random elements from 1 to 10. 
         *  Find the necessary information/help on the Internet!
         * 
         * static void FillArray(int[] array)
         */
        static void Main(string[] args)
        {
            // Make an array of any size (in this example it this 20).
            int[] array = new int[20];
            
            Console.Write("Before: ");
            PrintArray(array);
            
            FillArray(array);

            Console.Write("After : ");
            PrintArray(array);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        /**
         * Function that prints out the given array of integers on the console.
         * It will print them in a single line. A new line is put at the end.
         */
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        /**
         * Function that fills the array with random numbers between 1 and 10.
         * A random number generator object is made before the array is filled.
         */
        static void FillArray(int[] array)
        {
            Random generator = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = generator.Next(1, 10);
            }
        }

    }
}
