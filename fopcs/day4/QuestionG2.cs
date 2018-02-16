using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionG2
    {
        static void Main()
        {
            // implement simplified selection sort
            int[] a = new int[] { 3, 2, 1, 4, 0, 5 };
            // for i = the beginning of the array to the end
            for (int i = 0; i < a.Length - 1; i++) // don't need to swap 2nd last and last element
            {
                // for j = i to the array end
                for (int j = i; j < a.Length; j++)
                {
                    // if (i'th element > j'th element)
                    if (a[i] > a[j])
                    {
                        // swap the j'th and i'th element
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    // endif
                    // next j
                }
                // print out the line
                Console.WriteLine("Pass {0}: {1}", i + 1, String.Join(",", a));
                // next i
            }
        }
    }
}
