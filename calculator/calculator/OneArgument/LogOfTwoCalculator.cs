using System;

namespace calculator.OneArgument
{
    public class LogOfTwoCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find logarithm of argument by base 2
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Аргумент меньше нуля");
            }
            return Math.Log(firstValue, 2);
        }
    }
}
