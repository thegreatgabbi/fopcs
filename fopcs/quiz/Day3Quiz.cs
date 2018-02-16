using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTemplate
{
    class Day3Quiz
    {
        static void Main()
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase: ");
            int Items = Convert.ToInt32(Console.ReadLine());

            double PriceBeforeDiscount = Items * 500;
            double PriceAfterDiscount;

            if (PriceBeforeDiscount > 6000)
            {
                PriceAfterDiscount = PriceBeforeDiscount - (0.08 * PriceBeforeDiscount);
            }
            else if (PriceBeforeDiscount > 3000)
            {
                PriceAfterDiscount = PriceBeforeDiscount - (0.05 * PriceBeforeDiscount);
            }
            else if (PriceBeforeDiscount > 2000)
            {
                PriceAfterDiscount = PriceBeforeDiscount - (0.03 * PriceBeforeDiscount);
            }
            else
            {
                PriceAfterDiscount = PriceBeforeDiscount;
            }
            Console.WriteLine("\nPlease pay {0:C}", PriceAfterDiscount);
        }
    }
}
