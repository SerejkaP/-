using System;

namespace calculator.OneArgument
{
    public class SquareRootCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Отрицательное значение под корнем");
            }
            return Math.Sqrt(firstValue);
        }
    }
}
