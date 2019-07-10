using System;

namespace calculator.TwoArguments
{
    class GeometricMean : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Sqrt(firstValue * secondValue);
        }
    }
}
    
