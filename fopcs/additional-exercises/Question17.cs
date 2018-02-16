using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question17
    {
        public static void BinarySearch()
        {
            int[] a = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            // descending selection sort
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
            }

            Console.WriteLine("Sorted in descending order: " + String.Join(",", a));

            // implement binary search
            // 1. Set L to 0 and R to n − 1.
            int target = 6, leftLimit = 0, rightLimit = a.Length - 1;
            int middle;

            // 2. If L > R, the search terminates as unsuccessful.
            if ( leftLimit > rightLimit )
            {
                Console.WriteLine("Error.");
            } else
            {
                do
                {
                    // 3. Set m(the position of the middle element) to the floor(the largest previous integer) of(L + R) / 2.
                    middle = (leftLimit + rightLimit) / 2;
                    if (a[middle] < target)
                    {
                        // 4. If Am < T, set R to m-1 and go to step 2.
                        rightLimit = middle - 1;
                    }
                    else if (a[middle] > target)
                    {
                        // 5. If Am > T, set L to m+1 and go to step 2.
                        leftLimit = middle + 1;
                    }
                }
                // 6. Now Am = T, the search is done; return m.
                while (a[middle] != target);

                Console.WriteLine("{0} is at position {1}.", target, middle);
            }
            
            
            
            
        }

    }
}
