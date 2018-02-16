using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class QuestionC4
    {
        public static void Main()
        {
            // $ 2.40 (first 0.5 km) +
            //$ 85 * 0.04(next 8.5 km) +
            // $(122 - 90) * 0.05(for distance over 9.0 km)
            // = $7.40

            // Get the distance
            Console.WriteLine("Question 4");
            Console.Write("Enter the distance: ");
            double DistanceInHundreds = Convert.ToDouble(Console.ReadLine()) * 10;

            if (DistanceInHundreds <= 5)
            {
                Console.WriteLine("2.4");
            }
            else if ((DistanceInHundreds > 5) && (DistanceInHundreds <= 90))
            {
                double RemainingDistanceInHundreds = DistanceInHundreds - 5;
                double RoundedRemainingDistanceInHundreds = Math.Ceiling(RemainingDistanceInHundreds);
                double Cost = 2.4 + (RoundedRemainingDistanceInHundreds * 0.04);
                Console.WriteLine(Cost);
            }
            else if (DistanceInHundreds > 90)
            {
                double RemainingDistanceInHundreds = DistanceInHundreds - 90;
                double RoundedRemainingDistanceInHundreds = Math.Ceiling(RemainingDistanceInHundreds);
                double Cost = 2.4 + (85 * 0.04) + (RoundedRemainingDistanceInHundreds * 0.05);
                Console.WriteLine(Cost);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
