using System;

namespace Day3Exercises
{
    class QuestionD2
    {
        static void Main()
        {
            //Take in as input two numbers A and B.
            int A, B;
            int HCF;
            int LCM;

            Console.Write("Enter number A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            B = Convert.ToInt32(Console.ReadLine());

            //The above process is repeated until both the numbers are equal, say X.
            int A1 = A;
            int B1 = B;
            while ( A1 != B1 )
            {
                // Subtract the smaller of the two numbers from the Larger Number and assign the answer to the larger number.
                if (A1 > B1)
                {
                    // subtract B from A
                    A1 = A1 - B1;
                }
                else if (B1 > A1)
                {
                    // subtract A from B
                    B1 = B1 - A1;
                }
            }

            // Apparently the residual number(X) that we have obtained is the HCF.
            HCF = A1;
            //LCM could then be computed using the formula (A * B)/ HCF
            LCM = (A * B) / HCF;

            // Print out your answers.
            Console.WriteLine("The HCF is {0} and the LCM is {1}", HCF, LCM);

        }
    }
}
