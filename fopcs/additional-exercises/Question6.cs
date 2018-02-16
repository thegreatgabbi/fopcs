using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question6
    {
        public static void a()
        {
            for (int i = 0; i < 6; i++) // row
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void b()
        {
            int pad = 50;
            for (int i = 1; i < 6; i++) // row
            {
                for (int j = 0; j < pad; j++) // column
                    if (j < (pad - i))
                    {
                        Console.Write(" ");
                    } else
                    {
                        Console.Write("*");
                    }
                
                Console.WriteLine();
            }
        }
        public static void c()
        {
            int spaces = 20;
            string stars, spaceString;

            for (int i = 1; i < 6; i++) // row
            {
                if ( i % 2 == 0 ) // if the row is even
                {
                    spaces--;
                }
                spaceString = new String(' ', spaces);
                stars = new String('*', i);
                Console.WriteLine("{0}{1}", spaceString, stars);
            }
        }


    }
}
