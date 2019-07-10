using System;

namespace calculator.OneArgument
{
    public class LogOfTwoCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue,2);
        }
    }
}
