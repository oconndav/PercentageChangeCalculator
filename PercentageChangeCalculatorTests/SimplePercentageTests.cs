using Microsoft.VisualStudio.TestTools.UnitTesting;
using PercentageChangeCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageChangeCalculator.Tests
{
    [TestClass()]
    public class SimplePercentageTests
    {
        [TestMethod()]
        public void CalculatePercentageChangeTestNegative()
        {
            //arrange
            decimal numberOrig = 21;
            decimal numberNew = 15;
            decimal calculatedResult;
            decimal expectedResult = -28.571428571428571428571428570M;

            //act
            calculatedResult = SimplePercentage.CalculatePercentageChange(numberOrig, numberNew);



            //assert
            Console.WriteLine($"calculated result is {calculatedResult}");


            if (calculatedResult != expectedResult)
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void CalculatePercentageChangeTestPOSTIVE()
        {
            //arrange
            decimal numberOrig = 49;
            decimal numberNew = 53;
            decimal calculatedResult;
            decimal expectedResult = 8.163265306122448979591836730M;

            //act
            calculatedResult = SimplePercentage.CalculatePercentageChange(numberOrig, numberNew);

            //assert
            Console.WriteLine($"calculated result is {calculatedResult}");


            if (calculatedResult != expectedResult)
            {
                Assert.Fail();
            }


        }
    }
}