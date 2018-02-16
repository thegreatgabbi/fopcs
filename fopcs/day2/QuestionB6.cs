using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB6
    {
        public static void Question6()
        {
            // get x, y coordinates (integers) of 2 points
            int x1, x2, y1, y2;
            Console.WriteLine("Question 6");
            Console.Write("Enter x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            // Distance = Square Root of [( x2 – x1 ) 2 + ( y2 – y1 ) 2 ]
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            // output distance (double)
            Console.WriteLine(distance);
        }
    }
}
