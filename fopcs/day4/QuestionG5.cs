using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionG5
    {
        static void Main()
        {
            // create an array of certain size and fill it up with numbers
            int[] numbers = new int[10];

            // generate the numbers
            // - use a for-loop to generate numbers
            for (int i = 0; i <= 9; i++)
            {
                numbers[i] = i + 1;
            };

            // Ask user for a number
            Console.Write("Enter a number: ");
            int query = Convert.ToInt32(Console.ReadLine());

            // return the position of that number in the array
            int position = Array.IndexOf(numbers, query) + 1;

            if (position != -1)
            {
                Console.WriteLine("Number {0} is found in the array at the element no {1}.", query, position);
            }
            else
            {
                // else return -1 if the number cannot be found
                Console.WriteLine("-1");
            }
        }
    }
}
