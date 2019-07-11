using System;

namespace calculator.TwoArguments
{
    public class PowerOfDivision : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return Math.Pow(firstValue, (1 / secondValue));
        }
    }
}
