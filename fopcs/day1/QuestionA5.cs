using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class QuestionA5
    {
        static void Main()
        {
            Console.Write("Enter a double precision number: ");
            double number5 = Convert.ToDouble(Console.ReadLine());
            //// print the number with 2 decimal points in the output
            Console.WriteLine("{0:0.00}", number5);
        }
    }
}
