using System;

namespace Day3Exercises
{
    class QuestionD3a
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
                }
            }
            // if the guess is correct
            // congratulate the player
            // tell how many attempts that you took to make the guess
            Console.WriteLine("Congratulations! You took {0} attempts.", counter);
        }
    }
}
