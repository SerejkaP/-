using System;

namespace calculator.TwoArguments
{
    public class DivideCalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return (int)(firstValue / secondValue);
        }
    }
}
