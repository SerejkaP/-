using System;

namespace calculator.OneArgument
{
    public class TwoPowerValues : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find two in degree of argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Pow(2, firstValue);
        }
    }
}
