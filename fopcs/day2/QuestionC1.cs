using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionC1
    {
        public static void Main()
        {
            Console.WriteLine("Question 1");
            // Get name
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            // Get gender
            Console.Write("Enter M for Male and F for Female: ");
            string Gender = Console.ReadLine();
            // If gender is M, print "Mr."
            // Else If gender is F, print "Ms."
            // Else print "You're an alien."
            switch (Gender)
            {
                case "M":
                    Console.WriteLine("Good Morning Mr. {0}", Name);
                    break;
                case "F":
                    Console.WriteLine("Good Morning Ms. {0}", Name);
                    break;
                default:
                    Console.WriteLine("You are an alien.");
                    break;
            }
        }

    }
}
