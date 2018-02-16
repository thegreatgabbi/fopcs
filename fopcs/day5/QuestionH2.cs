using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH2
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            QuestionH2.PrintArray(a, "-");
        }
        // write a static method PrintArray(int[] arr) that doesn't return any value
        // Prints out all the elements of an array in any format that you prefer
        static void PrintArray(int[] arr, string separator)
        {
            // join the array using the separator
            string s = String.Join(separator, arr);
            Console.WriteLine(s);
        }
    }
}
