using System;

namespace calculator.OneArgument
{
    public class LogOneArgument :IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Аргумент меньше нуля");
            }
            return Math.Log(firstValue);
        }
    }
}
