using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionF5b
    {
        static void Main()
        {
            string[] names = new string[] {"John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            // make a deep copy of names and sort it
            string[] sortedArray = new string[5];
            Array.Copy(names, sortedArray, 5);
            Array.Sort(sortedArray);
            // for each element in the sorted array, get the index from names to get the marks

            Console.WriteLine("Name\tMark");
            for (int i=0; i < sortedArray.Length; i++)
            {
                int j = Array.IndexOf(names, sortedArray[i]); // get the index of the sorted array
                Console.WriteLine("{0}\t{1}", sortedArray[i], marks[j]);
            }
        }
    }
}
