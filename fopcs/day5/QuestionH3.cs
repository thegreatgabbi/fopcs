using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH3
    {
        static void Main()
        {
            Console.WriteLine(InString("The brown fox", "O"));
            Console.WriteLine(InString("The brown fox", "FOX"));
            Console.WriteLine(InString("The brown fox", "bRO"));
            Console.WriteLine(InString("T", "bRO"));
            Console.WriteLine(InString("The bras basah complex", "bRO"));
        }
        // Write static method that reutns a boolean
        static bool InString(string s1, string s2)
        {
            // find if the string s2 occurs in s1 - use IndexOf and Substr
            bool output;

            // sanitize s2 input - convert to lowercase
            s2 = s2.ToLower();
            int result = s1.IndexOf(s2); // -1 if not found

            if ( result == -1 )
            {
                output = false;
            } else
            {
                output = true;
            }

            return output;
        }
    }
}
