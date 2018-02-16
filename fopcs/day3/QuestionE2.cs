using System;

namespace Day3Exercises
{
    class ExerciseE2
    {
        static void Main()
        {
            Console.Write("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE\n");
            string dashes = new String('-', 65);
            Console.WriteLine(dashes);
 
            // for each number between 1 and 10
            for (int i = 1; i <= 10; i++)
            {
                // print no., inverse, square root and square
                double no, inverse, squareRoot, square;
                no = i;
                inverse = 1.0 / i;
                squareRoot = Math.Sqrt(i);
                square = i * i;

                Console.Write("{0:0.0##}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0##}\n", no, inverse, squareRoot, square);
            }
        }
    }
}
