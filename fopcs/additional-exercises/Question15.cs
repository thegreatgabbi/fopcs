using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question15
    {
        public static void NumberSearch()
        {
            int[] a = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int query = 10;

            //Random r = new Random();

            //for (int i = 0; i <= a.Length; i++)
            //{
            //    a[i] = r.Next(1, 11);
            //}

            int position = Array.IndexOf(a, query);
            if (position != -1)
            {
                Console.WriteLine("{0} found at position {1}", query, position);
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }

    }
}
