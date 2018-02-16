using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question2
    {
        public static string PrintNumber()
        {
            int[] a = new int[20];
            for (int i = 1; i <= 20; i++)
            {
                a[i - 1] = 20 - (i - 1);
            }
            return String.Join(" ", a);
        }
    }
}
