using System;

namespace calculator.TwoArguments
{
    public class MinTwoArguments :ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
           return Math.Min(firstValue,secondValue);
        }
    }
}
