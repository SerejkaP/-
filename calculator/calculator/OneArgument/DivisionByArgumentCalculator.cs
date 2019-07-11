using System;

namespace calculator.OneArgument
{
    public class DivisionByArgumentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            if (firstValue == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return 1 / firstValue;
        }
    }
}
