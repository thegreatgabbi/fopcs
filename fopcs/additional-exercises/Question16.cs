using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question16
    {
        public static void DescendingSort()
        {
            int[] a = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            // implement selection sort

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++ )
                {
                    if (a[j] > a[i])
                    {
                        int temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
                Console.WriteLine(String.Join(" ", a));
            }
        }

    }
}
