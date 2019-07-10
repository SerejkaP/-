using System;

namespace calculator.OneArgument
{
    public class LogOfTenCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log10(firstValue);
        }
    }
}
