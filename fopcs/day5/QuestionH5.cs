using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH5
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}: {1}", i, ToHex(i));
            }
        }
        // write a function that takes in integer and returns hexadecimal
        static string ToHex(int input)
        {
            string hex = "";
            // how to convert to hexadecimal?

            // - Divide the result again by 16. Treat the division as an integer division.
            // - Repeat step 2 and 3 until result is 0 - use while-loop
            while (input != 0)
            {
                // - Divide the decimal number by 16. Treat the division as an integer division.
                int remainder = input % 16;
                input = input / 16;
                // - Write down the remainder (in hexadecimal).
                if (remainder >= 10 && remainder <= 15)
                {
                    string letter = "";
                    switch(remainder) {
                        case 10:
                            letter = "a";
                            break;
                        case 11:
                            letter = "b";
                            break;
                        case 12:
                            letter = "c";
                            break;
                        case 13:
                            letter = "d";
                            break;
                        case 14:
                            letter = "e";
                            break;
                        case 15:
                            letter = "f";
                            break;
                    }
                    hex = letter + hex;
                } else
                {
                    hex = Convert.ToString(remainder) + hex;
                }
            }
            // - The hex value is the digit sequence of the remainders from the last to first.

            // print out the hex of all numbers 1 to 100 - do this in Main
            return hex;
        }
    }
}
