using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1_Palindrome
{
    internal class Question1_Palindrome
    {
        //1. Write a C# program to check whether a string is a palindrome.
        
        static void Main()
        {
            Console.Write("Enter a string: ");  // (example: Madam, level)
            string str = Console.ReadLine();

            // Check for null or empty input
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Invalid input");
                return;  // Exit the program if input is invalid.
            }

            string rev = "";

            foreach (char ch in str)
            {
                rev = ch + rev;  // reverse string
            }
            // // Compare original and reversed string.
            if (str.ToLower() == rev.ToLower())
                Console.WriteLine("It is a Palindrome.");
            else
                Console.WriteLine("It is not a palindrome.");
        }
    }
}
