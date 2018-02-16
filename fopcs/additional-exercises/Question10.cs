using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question10
    {
        public static void ThrowDice()
        {
            Random r = new Random();
            int dice;

            do
            {
                dice = r.Next(1, 7);
                Console.WriteLine(dice);
            }
            while (dice != 6);

        }
        
    }
}
