using System;

namespace Day4
{
    class Day4Quiz
    {
        static void Main()
        {
            bool correct = false;
            int counter = 3;
            int entry;
            int pin = 123456;

            Console.WriteLine("Welcome to the Bank of ISS");

            do
            {
                Console.Write("Enter your PIN: "); // enter your pin
                entry = Convert.ToInt32(Console.ReadLine()); // get entry
                counter--; // deduct from counter

                if (entry == pin)
                {
                    correct = true;
                    Console.WriteLine("PIN accepted. You can access your account now.");
                } else if (counter > 0 && entry != pin)
                {
                    Console.WriteLine("Incorrect PIN. Please try again. You have {0} more tries", counter);
                } else
                {
                    Console.WriteLine("Too many wrong PIN entries. Your account is now locked");
                }
            }
            while (!correct && counter > 0);
        }
    }
}
