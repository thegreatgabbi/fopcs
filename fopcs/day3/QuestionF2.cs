using System;

namespace Day3Exercises
{
    class QuestionF2
    {
        static void Main()
        {
            string word, newWord="";

            // get input
            Console.Write("Enter a word: ");
            word = Console.ReadLine();
            // get each character in the string, then add it to a new array

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newWord = newWord + word[i];
            }

            // compare strings
            if (newWord == word)
            {
                Console.WriteLine("\"{0}\" is a palindrome!", word);
            } else
            {
                Console.WriteLine("\"{0}\" is not a palindrome.", word);
            }
        }
    }
}
