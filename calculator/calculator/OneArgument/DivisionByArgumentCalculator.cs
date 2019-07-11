using System;

namespace calculator.OneArgument
{
    public class DivisionByArgumentCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method divide one to argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
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
