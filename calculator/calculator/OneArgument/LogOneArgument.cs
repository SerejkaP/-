using System;

namespace calculator.OneArgument
{
    class LogOneArgument:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Log(firstValue);
        }
    }
}
