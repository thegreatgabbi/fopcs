using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Exercises
{
    class QuestionD1
    {
        static void Main()
        {
            int number;
            bool IsCorrect = false;

            while (!IsCorrect)
            {
                Console.Write("Enter an integer number: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 88)
                {
                    IsCorrect = true;
                }
            }
            Console.WriteLine("Lucky you...");
        }
    }
}
