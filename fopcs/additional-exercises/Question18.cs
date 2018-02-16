using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question18
    {
        public static double[] ReturnAverage()
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
                for (int j = 0; j < a.GetLength(1); j++) // columns
                {
                    b[i] += a[i, j];
                }
                b[i] = Math.Round(b[i] / a.GetLength(1), 2);
            }

            return b;
        }

    }
}
