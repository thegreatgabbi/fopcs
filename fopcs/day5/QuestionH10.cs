using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH10
    {
        static void Main()
        {
            int[,] A = new int[4, 2] {
                { 7, 8 },
                { 9, 10 },
                { 11, 12 },
                { 13, 14 }
            };
            int[,] B = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Console.WriteLine(String.Join(",", MatrixMultiply(A, B)));
        }
        static int[,] MatrixMultiply(int[,] A, int[,] B)
        {
            int[,] A2 = new int[4, 3];
            for (int i = 0; i < 4; i++) // rows
            {
                for (int j = 0; j < 3; j++) // columns
                {
                    A2[i, j] = (A[i, 0] * B[0, j]) + (A[i, 1] * B[1, j]);
                }
            }
            return A2;
        }
    }
}
