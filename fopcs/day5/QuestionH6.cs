using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH6
    {
        static void Main()
        {
            Console.WriteLine(Substitute("Harry", 'r', 'l'));
        }
        static string Substitute(string s, char c1, char c2)
        {
            string output = "";
            // find all occurrences of the character c1 in the string s
            // - use for-loop
            for (int i = 0; i < s.Length; i++)
            {
                // if c1 matches s[i]
                if ( c1 == s[i] )
                {
                    // substitute c1 with character c2
                    output += c2;
                } else
                {
                    output += s[i];
                }
            }
            return output;
        }
    }
}
