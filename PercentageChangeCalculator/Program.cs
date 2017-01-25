using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageChangeCalculator
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our simple Percentage Change Calculator App");

            Console.WriteLine("Please enter the original number: ");
            decimal numberOrig = readInputNumber();

            Console.WriteLine("Please enter the new number: ");
            decimal numberNew = readInputNumber();

            decimal result = CalculatePercentageChange(numberOrig, numberNew);

            Console.WriteLine($"The result is: {result}");
            Console.ReadKey();   
        }

        public static decimal CalculatePercentageChange(decimal numberOrig, decimal numberNew)
        {
            decimal percentageChangeResult = 0;

            percentageChangeResult = ((numberNew - numberOrig) / numberOrig) * 100;

            return percentageChangeResult;
        }

        public static decimal readInputNumber()
        {
            decimal readInputnumber = decimal.Parse(Console.ReadLine());

            return readInputnumber;
        }

    }
}
