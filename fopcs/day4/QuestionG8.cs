using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionG8
    {
        static void Main()
        {
            int[,] numbers = new int[,] // 4 x 2
            {
                { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }
            };

            // ask user for a number
            // Report back with the index for that number
            int query;
            Console.Write("Enter a number: ");
            query = Convert.ToInt32(Console.ReadLine());

            // for reach row in array
            // if object contains the number
            // get index of object
            // get index of number

            int i=0, j=0;

            for (i = 0; i < 4; i++) // row
            {
                for (j = 0; j < 2; j++)
                {
                    if ( numbers[i,j] == query)
                    {
                        Console.WriteLine("Number {0} is found in the array at [{1},{2}]", query, i, j);
                    }
                }
            }
        }

    }
}
