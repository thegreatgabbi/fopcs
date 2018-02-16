using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question22
    {
        public static int[] ResizeArray(int[] array, int newSize)
        {
            int[] newArray = new int[newSize];

            // for element in array
            for (int i = 0; i < newSize; i++)
            {
                // if i < array.Length
                    // a[i] = a[i];
                // else
                    // a[i] = 0;
                if ( i < array.Length )
                {
                    newArray[i] = array[i];
                } else
                {
                    newArray[i] = 0;
                }
            }

            return newArray;
        }

    }
}
