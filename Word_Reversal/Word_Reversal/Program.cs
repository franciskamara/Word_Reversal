using System;

namespace Word_Reversal // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello there.\nPlease input a word you want to reverse: ");

            string userInput = Console.ReadLine().ToLower();

            string wordReversed = string.Empty;
            int reverseIndex = 0;
            //int lastIndex = userInput.Length - 1;

            for (int letterCount = 0; letterCount <= userInput.Length - 1; letterCount++)
            {
                Console.WriteLine($"Loop count: {letterCount}");

                // lastIndex = lastIndex-1;
                reverseIndex = userInput.Length - 1 - letterCount;//Counting through the loop by index
                char currentChar = userInput[reverseIndex];//Input is reversed
                wordReversed = wordReversed + currentChar;

            }
            Console.WriteLine($"Word entered: {userInput}");
            Console.WriteLine($"Word reversed: {wordReversed}");

            if (userInput == wordReversed)
            {
                Console.WriteLine($"{userInput} is a palindrome");
            }

        }
    }
}