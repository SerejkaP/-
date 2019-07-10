using System;

namespace calculator.OneArgument
{
    class TenPowerValues : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(10,firstValue);
        }
    }
}
