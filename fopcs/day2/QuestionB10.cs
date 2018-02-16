using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB10
    {
        public static void Main()
        {
            // AREA = SQUAREROOT[s(s-a)(s-b)(s-c)] where s = (a+b+c) / 2
            Console.WriteLine("Question 10");
            Console.Write("Enter a: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter c: ");
            double C = Convert.ToDouble(Console.ReadLine());
            // Area = NaN when s < a || s < b || s < c
            // check if s is lesser than a, b or c
            double S = (A + B + C) / 2;
            double Formula = (S * (S - A) * (S - B) * (S - C));
            if (Formula < 0)
            {
                Console.WriteLine("Can't calculate area");
            }
            else
            {
                double Area = Math.Sqrt(Formula);
                Console.WriteLine(Area);
            }

        }
    }
}
