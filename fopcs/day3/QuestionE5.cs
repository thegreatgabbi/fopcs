using System;

namespace Day3Exercises
{
    class QuestionE5
    {
        static void Main()
        {
            // for integers between 5 and 10000
            for (int j = 5; j <= 10000; j++)
            {
                bool prime = true;
                for (int i = 2; i < j; i++) // exclude 1 and itself
                {
                    // if the number is divisible by a number which is not itself, it is not a prime number
                    if (j % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
