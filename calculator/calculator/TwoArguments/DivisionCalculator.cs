using System;

namespace calculator.TwoArguments
{
    public class DivisionCalculator : ICalculator
    {
        /// <summary>
        /// this method do division of two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
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
