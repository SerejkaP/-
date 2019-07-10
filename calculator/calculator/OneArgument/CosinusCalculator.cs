using System;

namespace calculator.OneArgument
{
    class CosinusCalculator:IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
