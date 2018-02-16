using System;

namespace Day3Exercises
{
    class QuestionE3
    {
        static void Main()
        {
            // get integer
            int n;
            bool prime = true;

            Console.Write("Enter an integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i < n; i++) // exclude 1 and itself
            {
                // if the number is divisible by a number which is not itself
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
    
            if (prime)
            {
                Console.WriteLine("Prime");
            } else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
