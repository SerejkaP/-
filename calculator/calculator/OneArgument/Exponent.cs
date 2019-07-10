using System;

namespace calculator.OneArgument
{
    class Exponent: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
