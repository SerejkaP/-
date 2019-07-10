using System;

namespace calculator.TwoArguments
{
    public class PowerTwoArguments : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,secondValue); 
        }
    }
}
