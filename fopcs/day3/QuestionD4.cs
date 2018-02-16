using System;

namespace Day3Exercises
{
    class QuestionD4
    {
        static void Main()
        {
            // a. Take as input the number for finding the square root
            double g;
            int n;
            Console.Write("Enter an integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            // b. Take a random number between 1 and N using the function RND.
            Random r = new Random();
            // Let the integer be called a Guess, G (not necessarily an integer)
            g = r.Next(1, n);

            // c. If the Guess is correct than G*G should be N
            if (!((g * g) == n))
            {
                // while | n - (g * g) | < 0.00001 |
                while (!( Math.Abs(n - (g * g)) < 0.00001))
                {
                    g = (g + (n / g)) / 2;
                }
                // guess is correct
            }
            Console.WriteLine("The square root of 'n' is {0:0.000}", g);
        }
    }
}
