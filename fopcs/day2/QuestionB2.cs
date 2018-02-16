using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB2
    {
        public static void Main()
        {
            // take double precision number
            Console.WriteLine("Question 2");
            Console.Write("Enter a double precision number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            // print the square root of the number, rounded to 3 decimal places.
            Console.WriteLine("{0:0.000}", Math.Sqrt(number1));
        }
    }
}
