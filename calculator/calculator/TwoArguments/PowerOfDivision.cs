using System;

namespace calculator.TwoArguments
{
    public class PowerOfDivision : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue, (1 / secondValue));
        }
    }
}
