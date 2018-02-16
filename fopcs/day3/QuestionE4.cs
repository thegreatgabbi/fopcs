using System;

namespace Day3Exercises
{
    class QuestionE4
    {
        static void Main()
        {
            // take an integer as input
            int n;
            // store sum of factors
            int sum = 0;

            Console.Write("Enter an integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            // get its factors
            for (int i = 1; i < n; i++)
            {
                if ( n % i == 0 )
                {
                    sum = sum + i;
                }
            };
            if (sum == n)
            {
                Console.WriteLine("Perfect number");
            } else
            {
                Console.WriteLine("Not Perfect number");
            }

        }
    }
}
