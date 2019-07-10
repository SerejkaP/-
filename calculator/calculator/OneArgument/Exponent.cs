using System;

namespace calculator.OneArgument
{
    public class Exponent : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
