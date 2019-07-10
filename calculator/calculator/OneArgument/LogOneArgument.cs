using System;

namespace calculator.OneArgument
{
    public class LogOneArgument :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue);
        }
    }
}
