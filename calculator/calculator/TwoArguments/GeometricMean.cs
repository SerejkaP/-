using System;

namespace calculator.TwoArguments
{
    public class GeometricMean : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if ((firstValue < 0 && secondValue > 0) || (firstValue > 0 && secondValue < 0))
            {
                throw new Exception("Отрицательное значение под корнем");
            }
            return Math.Sqrt(firstValue * secondValue);
        }
    }
}
    
