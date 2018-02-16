using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question11
    {
        public static void TwoDice()
        {
            Random r = new Random();
            int one, two;

            do
            {
                one = r.Next(1, 7);
                two = r.Next(1, 7);
                Console.WriteLine("{0} {1}", one, two);
            }
            while (one != two);

        }
        
    }
}
