using System;

namespace Day3Exercises
{
    class QuestionD3b
    {
        // Guess the number that the computer has in it's mind
        static void Main()
        {
            // use the random number function
            Random r = new Random();
            int secretNum = r.Next(0, 9);
            // create flag
            bool correct = false;
            //
            int counter = 0;

            while (!correct)
            {
                // prompt for a guess
                Console.WriteLine("Guess the number: ");
                int guess = Convert.ToInt16(Console.ReadLine());
                counter++;
                if ( guess == secretNum ) {
                    correct = true;
                } else
                {
                    // prompt try again if you make a wrong guess
                    Console.WriteLine("Try again");
                }
            }
            // if the guess is correct
            if (counter <= 2)
            {
                Console.WriteLine("You are a Wizard!");
            } else if (counter > 2 && counter <= 5) {
                // "You are a good guess"
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("You are lousy!");
                // "You are lousy!"
            }
        }
    }
}
