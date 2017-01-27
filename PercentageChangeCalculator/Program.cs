/*
This is a very simple console app that takes two numbers and returns
the percentage change between the first number and the second number
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
           
            //user input is handled and valided by a reusable method
            decimal numberOrig = readInputNumber("original");            
            decimal numberNew = readInputNumber("new");

            //carry out the actual calculation
            decimal result = CalculatePercentageChange(numberOrig, numberNew);

            // display result back to user
            Console.WriteLine($"The change from your original number to your new number is: {result.ToString("0.##")}%");
            Console.WriteLine("Press any key to exit");
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
                
                decimal enteredNumber = 0;

                Console.WriteLine($"Please enter the {numberID} number: ");
                
                // ensure that the number entered is valid decimal
                if (decimal.TryParse(Console.ReadLine(), out enteredNumber))
                {
                    readInputnumber = enteredNumber;
                    numberOK = true;
                }
                else
                {
                    Console.WriteLine("Sorry invalid entry, please try again");
                }

            }
            while (!numberOK);

            return readInputnumber;



        }

    }
}
