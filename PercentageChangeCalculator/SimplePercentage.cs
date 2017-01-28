using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentageChangeCalculator
{
    public static class SimplePercentage
    {
        public static decimal CalculatePercentageChange(decimal numberOrig, decimal numberNew)
        {
            decimal percentageChangeResult = 0;

            percentageChangeResult = ((numberNew - numberOrig) / numberOrig) * 100;

            return percentageChangeResult;
        }
    }
}
