using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH7
    {
        static void Main()
        {
            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            // Console.WriteLine(String.Join("", myArray));
            SetArray(ref myArray, 1);
            Console.WriteLine(String.Join("", myArray));
        }
        static void SetArray(ref int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }
    }
}
