using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    public class QuestionG3
    {
        public static void Main()
        {
            int[,] a = new int[,]{
            { 56, 84, 68, 29 },
            { 94, 73, 31, 96 },
            { 41, 63, 36, 90 },
            { 99, 9, 18, 17 },
            { 62, 3, 65, 75, },
            { 40, 96, 53, 23 },
            { 81, 15, 27, 30 },
            { 21, 70, 100, 22 },
            { 88, 50, 13, 12 },
            { 48, 54, 52, 78 },
            { 64, 71, 67, 25 },
            { 16, 93, 46, 72 }
        };

            // a. Compute the total marks obtained by each student
            double[] totalMarks = new double[a.GetLength(0)]; // 12 students in class
            for (int i = 0; i < a.GetLength(0); i++) // for each student
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    totalMarks[i] += a[i, j];
                }
            }
            Console.WriteLine("The student total marks are: " + String.Join(",", totalMarks));


            // c. Compute the average per subject of each student
            double[] studentAverage = new double[a.GetLength(0)];

            // to get student average
            // take the total for each student (calculated in a) and divide it by 4
            for (int i = 0; i < a.GetLength(0); i++)
            {
                studentAverage[i] = totalMarks[i] / a.GetLength(1);
            }
            Console.WriteLine("The student averages are: " + String.Join(",", studentAverage));


            // b. Compute the class average (and standard deviation) of marks for each subject
            double[] classAverage = new double[a.GetLength(1)]; // 4
            double[] classStdDev = new double[a.GetLength(1)]; // 12

            // average = sum / n
            // stddev = Math.sqrt(variance)
            // variance = 

            // for each subject
            for (int i = 0; i < a.GetLength(1); i++) // 4
            {
                double sum = 0;
                for (int j = 0; j < a.GetLength(0); j++) // 12
                {
                    sum += a[j, i];
                    // divide by 12 (or a.Length)
                }

                classAverage[i] = sum / a.GetLength(0);

                double sumOfNumerator = 0;
                for (int k = 0; k < a.GetLength(0); k++)
                {
                    sumOfNumerator += Math.Pow(a[k, i] - classAverage[i], 2);
                }

                classStdDev[i] = Math.Sqrt(sumOfNumerator / a.GetLength(0));
            }
            Console.WriteLine("The class averages are: " + String.Join(",", classAverage));
            Console.WriteLine("The class standard deviations are: " + String.Join(",", classStdDev));
        }
    }
}
