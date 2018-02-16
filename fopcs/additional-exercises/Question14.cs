using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question14
    {
        public static void OneThenTwo()
        {
            Random r = new Random();
            int dice = 0;
            int previous = 0;

            do
            {
                previous = dice;
                // roll the dice
                dice = r.Next(1, 7);
                Console.WriteLine(dice);
                
            }
            while ( !( (previous == 1) && (dice == 2) ));
        }
        
    }
}
