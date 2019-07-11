using System;

namespace calculator.TwoArguments
{
    public class PowerOfDivision : ICalculator
    {
        /// <summary>
        ///  this method do power of first argument by division of second
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
            return Math.Pow(firstValue, (1 / secondValue));
        }
    }
}
