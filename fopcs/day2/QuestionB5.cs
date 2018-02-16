using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB5
    {
        public static void Main()
        {
            // take input value of x
            Console.WriteLine("Question 5");
            Console.Write("Enter the value of x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            // formula: y = 5x^2 – 4x + 3
            int y = (5 * Convert.ToInt32(Math.Pow(x, 2))) - (4 * x) + 3;
            // output value of y
            Console.WriteLine(y);
        }
    }
}
