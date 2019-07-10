using System;


namespace calculator.TwoArguments
{
    class MaxTwoArguments:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
