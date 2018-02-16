using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB4
    {
        public static void Main()
        {
            // Convert Centigade to Farenheit
            // F = 1.8C + 32

            // Take input as centigrade (can be real or integer)
            Console.WriteLine("Question 4");
            Console.Write("Enter the temperature in Farenheit: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (1.8 * c) + 32;
            // Output in Farenheit
            Console.WriteLine(f);
        }
    }
}
