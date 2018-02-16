using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question5
    {
        public static string MakePattern()
        {
            int[] a = new int[20];
            string output;

            int evenElement = 1;
            int oddElement = 20;

            for (int i = 0; i < 20; i++)
            {
                if ( i % 2 == 0 )
                {
                    a[i] = evenElement;
                    evenElement++;
                } else
                {
                    a[i] = oddElement;
                    oddElement--;
                }
            }

            output = String.Join(" ", a);
            return output;
        }
    }
}
