using System;

namespace calculator.TwoArguments
{
    class LogTwoArguments:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Log(firstValue, secondValue);
        }
    }
}
