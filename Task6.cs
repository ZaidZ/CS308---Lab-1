using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCS
{
    class Task6
    {
        /*
         * Task 6:
         * Write a C# program that contains a recursive function that checks
         *  whether a given string is a palindrome. A palindrome string is a 
         *  string that is identical whether you read it from the left or right, ex. “Civic”.
         *  One way to use recursion in this task is to start outward and continuously 
         *  go in the middle of the string, checking whether the two characters are 
         *  the same. Look at the example below.
         * 
         *  ABBDDCBA – Pass!
         *  BBDDCB – Pass!
         *  BDDC – Not same => Not palindrome
         *
         * static bool IsPalindrome(string s, int a, int b)
         */
        static void Main(string[] args)
        {
            string word = "anavolimilovana";

            // Print the result of the function
            Console.WriteLine(IsPalindrome(word, 0, word.Length - 1));

            // Stop the console from exiting immediately
            Console.ReadLine();
        }

        /**
         * A function that recursively checks whether a word is a palindrome.
         * 
         * The three parameters are given as:
         *  - string s - the word that needs to be checked
         *  - int a - the left letter index that needs to be checked
         *  - int b - the right letter index that needs to be checked
         */
        static bool IsPalindrome(string s, int a, int b)
        {
            // If the two indices reach each other, then it is a palindrome
            if (a >= b)
                return true;

            // If the two letters are not the same, it is NOT a palindrome
            if (s[a] != s[b])
                return false;

            // Keep checking, but now go one level inside the word
            return IsPalindrome(s, a + 1, b - 1);
        }
        
    }
}
