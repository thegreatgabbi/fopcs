using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH1
    {
        static void Main()
        {
            QuestionH1.ReadInteger("Enter an integer: ");
        }
        
        // write a static method ReadInteger(string message) that returns integer
        static int ReadInteger(string message)
        {
            // if input can be parsed into integer, return int
            // else repeat prompt until user enters integer
            bool canParse = false;
            int inputInt;

            do
            {
                // prompt the use with the message
                Console.Write(message);
                // get the input from the user
                string input = Console.ReadLine();
                // use TryParse?
                canParse = int.TryParse(input, out inputInt);
            }
            while (!canParse);

            return inputInt;
        }
    }
}
