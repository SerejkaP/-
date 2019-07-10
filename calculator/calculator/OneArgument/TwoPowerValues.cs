using System;

namespace calculator.OneArgument
{
    class TwoPowerValues : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Pow(2,firstValue);
        }
    }
}
