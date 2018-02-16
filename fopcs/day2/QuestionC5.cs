using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionC5
    {
        public static void Main()
        {
            // confine the input to 3 numbers only
            Console.WriteLine("Question 5");
            Console.Write("Enter first digit: ");
            int Input1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second digit: ");
            int Input2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third digit: ");
            int Input3 = Convert.ToInt32(Console.ReadLine());
            // convert to a string
            int ThreeDigitNumber = Convert.ToInt32(String.Format("{0}{1}{2}", Input1, Input2, Input3));

            if ((Math.Pow(Input1, 3) + Math.Pow(Input2, 3) + Math.Pow(Input3, 3)) == ThreeDigitNumber)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }

    }
}
