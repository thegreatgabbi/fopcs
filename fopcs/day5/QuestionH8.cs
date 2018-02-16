using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    
class QuestionH8
    {
        static void Main()
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(String.Join("", ResizeArray(myArray, 10)));
        }
        static int[] ResizeArray(int[] arr, int newSize)
        {
            int[] newArray = new int[newSize];
            Array.Copy(arr, newArray, arr.Length);
            // return a new array with the newSize

            return newArray;
        }
    }
}
