using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Day5Quiz
    {
        static void Main()
        {
            int[,] theArray = new int[,]
            {
                {5,3},{2,9},{2,9},
                {5,1},{7,1},{8,3},
                {0,3},{2,2},{9,7}
            };

            int count = 0;

            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            // Your code here
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (theArray[i, j] == input)
                    {
                        count++;
                    }
                }
            }
            if (count > 1)
            {
                Console.WriteLine("The number of {0} is {1}", input, count);
            }
            else
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }

        }
    }
}
