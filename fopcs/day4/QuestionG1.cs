using System;
using System.Linq; // required to use Array.Max and Array.Min

namespace Day4
{
    class QuestionG1
    {
        static void Main()
        {
            // 1. Take in the sales for the 12 months

            // Ask for the sales of the 12 months
            Console.Write("Enter the sales of the 12 months: ");
            string entry = Console.ReadLine();
            string[] sales = entry.Split(','); // split the string
            double[] salesDbl = Array.ConvertAll(sales, Convert.ToDouble); // convert all to ints

            // 2. Print the month where Maximum Sales is recorded
            double maxSales = salesDbl.Max();
            int maxSalesIndex = Array.IndexOf(salesDbl, maxSales);
            Console.WriteLine("Maximum Sales: {0}", maxSalesIndex);

            // 3. Print the month where Minimum Sales is recorded
            double minSales = salesDbl.Min();
            int minSalesIndex = Array.IndexOf(salesDbl, minSales);
            Console.WriteLine("Minimum Sales: {0}", minSalesIndex);

            // 4. Print the average monthly sales for the year
            double avgSales = salesDbl.Average();
            Console.WriteLine("Average monthly sales: {0}", avgSales);
        }
    }
}
