using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB1
    {
        public static void Main()
        {
            // take double precision number
            Console.WriteLine("Question 1");
            Console.Write("Enter a double precision number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            // print the square root of the number
            Console.WriteLine(Math.Sqrt(number1));
        }
    }
}
