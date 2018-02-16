using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercises.Properties
{
    class QuestionF1a
    {
        static void Main()
        {
            int counter = 0;
            string phrase;

            Console.WriteLine("Enter a phrase:");
            phrase = Console.ReadLine();
            phrase = phrase.ToLower();

            // read phrase from input
            for (int i = 0; i < phrase.Length; i++)
            {
                
                // substring one character at a time
                char c = phrase[i];

                // match to vowels
                if (c == 'a' || c == 'e' || c == 'i' ||
                    c == 'o' || c == 'u' )
                {
                    // increment the counter
                    counter++;
                }
            }

            Console.WriteLine(counter);
            
            
            
            

        }
    }
}
