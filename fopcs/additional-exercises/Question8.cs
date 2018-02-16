using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question8
    {
        public static void MakeNumberTree()
        {

            for (int i = 1; i <= 5; i++) // row
          {
              for (int j = 1; j <= i; j++)
              {
                Console.Write(j + " ");
              }
              Console.WriteLine();
          }
        }
    }
}
