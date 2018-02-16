using System;

namespace Day3Exercises
{
    class QuestionE6
    {
        static void Main()
        {
            
            for (int j=1; j <= 1000; j++)
            {
                // store sum of factors
                int sum = 0;

                // get its factors
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        sum = sum + i;
                    }
                };
                if (sum == j)
                {
                    Console.WriteLine(j);
                };
            }
        }
    }
}
