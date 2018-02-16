using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question3
    {
        public static string a()
        {
            string a = "";
            // Odd numbers between 1 and 20
            for (int i = 1; i <= 20; i=i+2)
            {
                a += (i + " ");
            }
            return a.Substring(0, a.Length - 1);
        }

        public static string b()
        {
            string a = "";
            // Odd numbers between 1 and 20
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    a += (i + " ");
                }
            }
            return a.Substring(0, a.Length - 1);
        }
    }
}
