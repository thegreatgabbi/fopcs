using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    class QuestionA4
    {
        static void Main()
        {
            Console.Write("Enter a double precision number: ");
            double number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(number4, 2));
        }
    }
}
