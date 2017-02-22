using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCS
{
    class Task5
    {
        /*
         * Task 5:
         * Write a C# program which contains a string with value “I only know JAVA”. 
         *  Your task is to first turn the original string to “I know JAVA” using the 
         *  Substring function. After that, replace “JAVA” with “C#” using the Replace function. 
         *  Add an exclamation mark to the end and then print the final string.
         * 
         */
        static void Main(string[] args)
        {
            string sentence = "I only know JAVA";

            Console.WriteLine(sentence);

            // Cut into two pieces: "I " + "know JAVA"
            sentence = sentence.Substring(0, 2) + sentence.Substring(7);

            Console.WriteLine(sentence);

            // Replace all occurrences of "JAVA" with "C#"
            sentence = sentence.Replace("JAVA", "C#");

            Console.WriteLine(sentence);

            // Add an exclamation mark, beacause why not.
            sentence = sentence + "!";

            Console.WriteLine(sentence);

            // Stop the console from exiting immediately
            Console.ReadLine();
        }
        
    }
}
