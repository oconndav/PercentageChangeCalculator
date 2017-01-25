/*
This is a very simple console app that takes two numbers and returns
the percentage change between the first number and the second
*/


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

            
            decimal numberOrig = readInputNumber("original");

            
            decimal numberNew = readInputNumber("new");

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

        public static decimal readInputNumber(string numberID)
        {
            bool numberOK = false;
            decimal readInputnumber = 0;

            do
            {
                try
                {
                    Console.WriteLine($"Please enter the {numberID} number: ");
                    readInputnumber = decimal.Parse(Console.ReadLine());
                    numberOK = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            while (!numberOK);

            return readInputnumber;



        }

    }
}
