using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionF4
    {
        static void Main()
        {
            // Convert string to sentence case
            string a = "institute of systems science";
            string[] s = a.Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                // change the first character to UpperCase
                string currentString = s[i];
                string firstChar = currentString.Substring(0, 1);
                string remainingChar = currentString.Substring(1, currentString.Length - 1);
                firstChar = firstChar.ToUpper(); // capitalize first letter
                s[i] = firstChar + remainingChar;
            }
            // join back the word
            string output = String.Join(" ", s);
            Console.WriteLine("{0}", output);
        }
    }
}
