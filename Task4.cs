using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCS
{
    class Task4
    {
        /*
         * Task 4:
         * Write a C# program in which an array of 5 integers is created. 
         *  The array is filled with random numbers. Write a function that expands the 
         *  array, doubling its size. The new indices are filled with the last number 
         *  of the original array.
         * 
         * Original array: 3 1 5 4 2
         * New array: 3 1 5 4 2 2 2 2 2 2
         * 
         * static void ExpandArray(int[] array)
         */
        static void Main(string[] args)
        {
            int[] array = new int[5];

            FillArray(array);

            Console.Write("Original array: ");
            PrintArray(array);

            /* The array is passed by reference so that all changes made
             *  by the function ExpandArray are also "visible" from here.
             */
            ExpandArray(ref array);

            Console.Write("New array: ");
            PrintArray(array);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        /**
         * A function that doubles the size of the given array.
         * The new elements of the array are filled with the last
         * value of the given array, i.e. array[array.Length - 1].
         */
        static void ExpandArray(ref int[] array)
        {
            // Create a new array, which has twice the capacity
            int[] newArray = new int[array.Length * 2];

            // First copy the first part of the array
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            // The second part of the array is filled with the last element of the old array
            for (int i = array.Length; i < 2 * array.Length; i++)
            {
                newArray[i] = array[array.Length - 1];
            }

            // The old array is now the newly constructed array
            array = newArray;
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
