using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question23
    {
        public static void RankSize(ref int a, ref int b)
        {
            if ( a > b )
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }

    }
}
