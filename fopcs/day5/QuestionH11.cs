using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH11
    {
        delegate double DoubleOps(double x);

        static void Main()
        {
            double[] a = new double[] { 2, 4, 6, 8, 10, 16 };
            Console.WriteLine(String.Join(",", a));

            DoubleOps myOp = squareRoot;      
            Console.WriteLine(String.Join(",", ProcessArray(a, myOp)));

            myOp = square;
            Console.WriteLine(String.Join(",", ProcessArray(a, myOp)));

            double squareRoot(double d)
            {
                return Math.Sqrt(d);
            };
            double square(double d)
            {
                return d * d;
            };
        }

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] newArray = new double[arr.Length];

            // apply the delegate on each of the elements of arr and assign it to the corresponding elements in the new array
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = ops(arr[i]);
            }
            // return an array that has the same size as arr
            return newArray;
        }

    }
}
