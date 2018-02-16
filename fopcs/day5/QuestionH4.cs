using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH4
    {
        static void Main()
        {
            Console.WriteLine(FindWord("The brown fox", "o"));
            Console.WriteLine(FindWord("The brown fox", "FOX"));
            Console.WriteLine(FindWord("The brown fox", "bRO"));
            Console.WriteLine(FindWord("T", "bRO"));
            Console.WriteLine(FindWord("The bras basah complex", "bRO"));
        }
        // Write static method that reutns a boolean
        static int FindWord(string s1, string s2)
        {
            // sanitize s2 input - convert to lowercase
            s2 = s2.ToLower();
            int result = s1.IndexOf(s2); // -1 if not found          

            return result;
        }

    }
}
