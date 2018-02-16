using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionB9
    {
        public static void Main()
        {
            // get kilometres travelled as input (double)
            Console.WriteLine("Question 9");
            Console.Write("Enter distance travelled: ");
            double Distance = Convert.ToDouble(Console.ReadLine());
            // fare = 2.40 + 3.24 * 0.4
            double Fare = 2.40 + (Distance * 0.4);
            // separate the integer and decimal parts
            double Integer = Math.Truncate(Fare);
            // get decimal part, then multiply by 10
            double Decimal = (Fare - Integer) * 10;
            int RoundedDecimal = Convert.ToInt32(Math.Ceiling(Decimal));
            Console.WriteLine("{0}.{1}", Integer, RoundedDecimal);
        }
    }
}
