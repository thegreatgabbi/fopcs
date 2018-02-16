using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionF6
    {
        static void Main()
        {
            string n;

            // check that the length of the input is exactly 7 characters
            do
            {
                Console.Write("Enter a matriculation number: ");
                n = Console.ReadLine();
                if (n.Length != 7)
                {
                    Console.Write("Invalid input");
                }
            }
            while (n.Length != 7);

            // convert the entire string to uppercase so that we don't have to worry about case
            n = n.ToUpper();

            // calculate the checksum based on the rule
            int multiplier = 6, sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                sum = sum + ( n[i] * multiplier );
                multiplier--;
            }
            // divide by 5 and take the remainder
            int remainder = sum % 5;

            // check whether the last character matches the calculated checksum.
            char checksum = n[6]; // e.g. X
            char[] calculatedChecksum = new char[5] { 'O', 'P', 'Q', 'R', 'S' };

            int calculatedChecksumIndex = Array.IndexOf(calculatedChecksum, checksum);

            if (remainder == calculatedChecksumIndex)
            {
                Console.WriteLine("Valid");
            } else
            {
                Console.WriteLine("Invalid");
            }            
        }
    }
}
