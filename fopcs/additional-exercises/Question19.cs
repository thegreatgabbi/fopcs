using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question19
    {
        public static double[] ReturnMax()
        {
            int[,] a = new int[,] {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 7, 8, 9 },
                { 8, 7, 2 },
                { 7, 7, 7 }
            };

            double[] b = new double[a.GetLength(0)];

            for (int i = 0; i < a.GetLength(0); i++) // rows
            {
                b[i] = a[i, 0]; // get first element
                for (int j = 0; j < a.GetLength(1); j++) // columns
                {
                    if (a[i, j] > b[i])
                    {
                        b[i] = a[i, j];
                    }
                }
            }

            return b;
        }

    }
}
