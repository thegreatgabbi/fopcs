using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class QuestionH9
    {
        static void Main()
        {
            for (int i = 5; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IsPrime(int n)
        {
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                if ( n % i == 0 )
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
