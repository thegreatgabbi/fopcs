using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    class Question7
    {
        public static void InverseTree()
        {
            int spaces = 20;
            string stars, spaceString;

            for (int i = 6; i >= 1; i--) // row
            {
                if (i % 2 == 0) // if the row is even
                {
                    spaces++;
                }
                spaceString = new String(' ', spaces);
                stars = new String('*', i);
                Console.WriteLine("{0}{1}", spaceString, stars);
            }
        }
    }
}
