using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    public class QuestionA1
    {
        public static void Main()
        {
            // Ask for name
            Console.Write("enter your name: ");
            string name1 = Console.ReadLine();
            // ask for email
            Console.Write("enter your email: ");
            string email1 = Console.ReadLine();
            // output name
            Console.WriteLine("line 1: " + name1);
            // output email
            Console.WriteLine("Line 2: " + email1);
        }
    }
}
