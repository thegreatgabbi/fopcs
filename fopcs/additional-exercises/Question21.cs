using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question21
    {
        public static void CreateTriangle(int type, int height)
        {
            string[] typeArray = new string[] {
                "leftAligned", "center", "rightAligned",
                "invertedleftAligned", "invertedCenter", "invertedRightAligned"
            };

            switch (typeArray[type])
            {
                case "leftAligned":
                    for (int i = 0; i < height; i++) // row
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "center":
                    int spaces = height;
                    string stars, spaceString;

                    for (int i = 1; i < height; i++) // row
                    {
                        if (i % 2 == 0) // if the row is even
                        {
                            spaces--;
                        }
                        spaceString = new String(' ', spaces);
                        stars = new String('*', i);
                        Console.WriteLine("{0}{1}", spaceString, stars);
                    }
                    break;
                case "rightAligned":
                    for (int i = 0; i < height; i++) // row
                    {
                        for (int j = 0; j < height; j++) // column
                            if ( j < ( height - (i + 1) ) )
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        Console.WriteLine();
                    }
                    break;
                case "invertedleftAligned":
                    for (int i = 0; i < height; i++) // row
                    {
                        for (int j = height - i; j > 0; j--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "invertedCenter":
                    spaces = 0;

                    for (int i = 1; i < height; i++) // row
                    {
                        if (i % 2 == 0) // if the row is even
                        {
                            spaces++;
                        }
                        spaceString = new String(' ', spaces);
                        stars = new String('*', height - i);
                        Console.WriteLine("{0}{1}", spaceString, stars);
                    }
                    break;
                case "invertedRightAligned":
                    for (int i = 0; i < height; i++) // row
                    {
                        for (int j = height; j > 0; j--) // column
                            if (j <= (height - i)) // if current index of j is 
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        Console.WriteLine();
                    }
                    break;
            }

        }

    }
}
