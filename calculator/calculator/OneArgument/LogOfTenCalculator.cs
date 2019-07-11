using System;

namespace calculator.OneArgument
{
    public class LogOfTenCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find logarithm of argument by base 10 
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Аргумент меньше нуля");
            }
            return Math.Log10(firstValue);
        }
    }
}
