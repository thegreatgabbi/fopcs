using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionF3
    {
        static void Main()
        {

            string sentence, newSentence = "";

            // get input
            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();

            // strip sentence of all whitespace, uppercase and spaces
            for (int i = 0; i <= sentence.Length - 1; i++)
            {
                if ( Char.IsLetter(sentence[i]) )
                {
                    char c = Char.ToLower(sentence[i]);
                    newSentence = newSentence + c;
                }
            }

            // reverse sentence
            string reversedSentence = "";
            for (int j = newSentence.Length - 1; j >= 0; j--)
            {
                reversedSentence = reversedSentence + newSentence[j];
            }

            // compare strings
            if (newSentence == reversedSentence)
            {
                Console.WriteLine("\"{0}\" is a palindrome!", sentence);
            }
            else
            {
                Console.WriteLine("\"{0}\" is not a palindrome.", sentence);
            }

        }
    }
}
