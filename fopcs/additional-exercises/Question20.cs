using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question20
    {
        public static double[,] ReturnAverage()
        {
            double[,,] a = new double[,,] {
                { { 1, 2, 3 }, { 3, 4, 5 }, { 4, 5, 6 } },
                { { 10, 5, 0 }, { 10, 9, 8 }, { 10, 4, 4 } },
                { { 5, 5, 5 }, { 0, 9, 9 }, { 9, 9, 9 } }
            };

            double[,] b = new double[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++) // 1st dimension
            {
                for (int j = 0; j < a.GetLength(1); j++) // 2nd dimension
                {
                    b[i, j] = 0;
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        b[i, j] += a[i, j, k];
                    }
                    b[i, j] = b[i, j] / a.GetLength(2);
                }
            }
            return b;

        }

    }
}
