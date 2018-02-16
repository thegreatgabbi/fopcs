using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionC3
    {
        public static void Main()
        {
            // Take an integer number between 0 and 100
            Console.WriteLine("Question 3");
            Console.Write("Enter your test score: ");
            int Score = Convert.ToInt32(Console.ReadLine());
            // Print: You scored 73 marks which is B grade.
            if (Score < 0 || Score > 100)
            {
                Console.WriteLine("**Error**");
            }
            else
            {
                if (Score >= 0 && Score < 40)
                {
                    Console.WriteLine("F");
                }
                else if (Score >= 40 && Score <= 59)
                {
                    Console.WriteLine("C");
                }
                else if (Score >= 60 && Score <= 89)
                {
                    Console.WriteLine("B");
                }
                else if (Score >= 90 && Score <= 100)
                {
                    Console.WriteLine("A");
                }
            }
        }
    }
}
