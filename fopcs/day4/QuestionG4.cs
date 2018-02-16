using System;

namespace Day4
{
    class QuestionG4
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

            // print the content of the array to the screen in the following format
            // - Array has a 
            string output = String.Join(",", numbers);
            Console.WriteLine("[{0}]", output);
        }
    }
}
