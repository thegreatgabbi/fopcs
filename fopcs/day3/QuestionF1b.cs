using System;

namespace Day3Exercises.Properties
{
    class QuestionF1b
    {
        static void Main()
        {
            int counter = 0;
            int counterA = 0;
            int counterE = 0;
            int counterI = 0;
            int counterO = 0;
            int counterU = 0;

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
                switch (c)
                {
                    case 'a':
                        counter++;
                        counterA++;
                        break;
                    case 'e':
                        counter++;
                        counterE++;
                        break;
                    case 'i':
                        counter++;
                        counterI++;
                        break;
                    case 'o':
                        counter++;
                        counterO++;
                        break;
                    case 'u':
                        counter++;
                        counterU++;
                        break;
                }
            }

            Console.WriteLine("Total vowels: {0}\n\nA: {1}\n\nE: {2}\n\nI: {3}\n\nO: {4}\n\nU: {5}\n", counter, counterA, counterE, counterI, counterO, counterU);





        }
    }
}
