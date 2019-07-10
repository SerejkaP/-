using System;

namespace calculator.TwoArguments
{
    public class GeometricMean : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Sqrt(firstValue * secondValue);
        }
    }
}
    
