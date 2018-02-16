using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA4102
{
    class Day6Quiz
    {
        // these arrays is visible in all the static method,
        // so you can use them in your method implementation

        static int[] minIncomeArray = new int[]
            { 20000, 30000, 40000, 80000,
            120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
            { 0.02, 0.035, 0.07, 0.115,
            0.15, 0.17, 0.18, 0.20};
        static int[] basePayableAmountArray = new int[]
            { 0, 200, 550, 3350,
            7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        static int AskForIncome()
        {
            Console.WriteLine("Please enter your annual taxable income.");
            int income = Convert.ToInt32(Console.ReadLine());
            return income;
        }

        static int GetTaxBracket(int income)
        {
            for (int i = 0; i < minIncomeArray.Length; i++)
            {
                if (income >= minIncomeArray[i])
                {
                    return i;
                } 
            }
            return -1;

        }

        static double CalculateIncomeTax(int income, int index)
        {
            double payableTax;
            double annualIncome = Convert.ToDouble(income);

            if (index == -1)
            {
                payableTax = 0;
            }
            else
            {
                double minIncome = minIncomeArray[index];
                double taxRate = taxRateArray[index];
                double basePayable = basePayableAmountArray[index];

                payableTax = ((annualIncome - minIncome) * taxRate) + basePayable;
            }
            return payableTax;
        }

        static void PrintResult(int income, double tax)
        {
            Console.WriteLine("For taxable annual income of {0:C}, the tax payable amount is {1:C}", income, tax);
        }

    }
}
