using System;

namespace calculator.TwoArguments
{
    class MinTwoArguments:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
           return Math.Min(firstValue,secondValue);
        }
    }
}
