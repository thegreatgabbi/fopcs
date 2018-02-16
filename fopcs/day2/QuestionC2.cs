using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionC2
    {
        public static void Main()
        {
            // Request for Name, Gender and Age
            string Name, Gender;
            int Age;
            Console.Write("What is your name: ");
            Name = Console.ReadLine();
            Console.Write("Type M for Male and F for Female: ");
            Gender = Console.ReadLine();
            Console.Write("What is your age? ");
            Age = Convert.ToInt32(Console.ReadLine());

            if ((Age > 0) && (Age <= 40))
            {
                if (Gender == "M")
                {
                    // if gender == M && age <= 40, Salutation = Mr
                    Console.WriteLine("Good morning Mr " + Name);
                }
                else if (Gender == "F")
                {
                    // if gender == F && age <= 40, Salutation = Ms.
                    Console.WriteLine("Good morning Ms. " + Name);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else if (Age > 40)
            {
                if (Gender == "M")
                {
                    // if gender == M && age > 40, Salutation = Uncle
                    Console.WriteLine("Good morning Uncle " + Name);
                }
                else if (Gender == "F")
                {
                    // if gender == F && age > 40, Salutation = Aunty
                    Console.WriteLine("Good morning Aunty " + Name);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

    }
}
