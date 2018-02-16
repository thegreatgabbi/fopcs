using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionG6
    {
        static void Main()
        {
            // create an array of certain size and fill it up with numbers
            int[] numbers = new int[10];
            Random random = new Random();

            // generate the numbers
            // - use a for-loop to generate numbers
            for (int i = 0; i <= 9; i++)
            {
                numbers[i] = random.Next(1,10);
            };
            Console.WriteLine("Original array: ");
            Console.WriteLine(String.Join(",", numbers));

            // For now, use Array.Sort()
            Array.Sort(numbers);

            // to print string
            Console.Write("Sorted array: ");
            Console.WriteLine(String.Join(",", numbers));

        }
    }
}
