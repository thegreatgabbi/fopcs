using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB3
    {
        public static void Main()
        {
            // housing allowance = 10%
            // transport allowance = 3%

            // take a salary as input
            Console.WriteLine("Question 3");
            Console.Write("Enter your salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            double housing = 0.1 * salary;
            double transport = 0.03 * salary;
            double total = salary + housing + transport;
            // print salary + housing allowance + transport allowance currency format
            Console.WriteLine("{0:C}", total);
        }
    }
}
