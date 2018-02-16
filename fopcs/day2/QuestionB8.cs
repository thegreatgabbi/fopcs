using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB8
    {
        public static void Main()
        {
            // get kilometres travelled as input (double)
            Console.WriteLine("Question 8");
            Console.Write("Enter distance travelled: ");
            double Distance = Convert.ToDouble(Console.ReadLine());
            // fare = 2.40 + 3.24 * 0.4
            double Fare = 2.40 + (Distance * 0.4);
            // round to the nearest 10 cents
            double RoundedFare = Math.Round(Fare, 1);
            // output the total fare to 2 decimal places
            Console.WriteLine("{0:0.00}", RoundedFare);
        }
    }
}
