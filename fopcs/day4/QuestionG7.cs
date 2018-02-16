using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class QuestionG7
    {
        static void Main()
        {
            // create 2 arrays, name and score
            string[] name = new string[7] { "Alice", "Bob", "Charlie", "Dennis", "Eli", "Frank", "Gina" };
            int[] score = new int[7] { 100, 90, 120, 80, 76, 66, 88 };

            // print the players with their scores with the player names sorted in ascending order
            // make sure you format as per the question
            Console.WriteLine("Name\tScore");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("{0}\t{1}", name[i], score[i]);
            }
        }
    }
}
