using System;

namespace Day3Exercises
{
    class QuestionE1a
    {
        static void Main()
        {
            // given a number, find its factorial
            int n, answer=0;
            Console.Write("Enter an integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++ ) // using an increment counter
            {
                answer = answer + i;
            }
            Console.WriteLine(answer);

            // Won't work for real numbers
        }
    }
}
