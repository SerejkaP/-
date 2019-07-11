using System;

namespace calculator.TwoArguments
{
    public class DivisionCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return firstValue / secondValue;
        }
    }
}
