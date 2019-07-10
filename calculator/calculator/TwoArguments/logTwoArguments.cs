using System;

namespace calculator.TwoArguments
{
    public class LogTwoArguments :ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}
