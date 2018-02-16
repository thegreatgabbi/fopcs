using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question13
    {
        public static void ThreeInARow()
        {
            Random r = new Random();
            int dice = 0;
            int previous = 0;
            int counter = 1;

            do
            {
                previous = dice;
                // roll the dice
                dice = r.Next(1, 7);
                Console.WriteLine(dice);
                if ( dice == previous )
                {
                    counter++;
                } else
                {
                    counter = 1;
                }
            }
            while ( counter != 3);
                
             
        }
        
    }
}
