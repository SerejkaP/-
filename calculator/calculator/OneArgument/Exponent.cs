using System;

namespace calculator.OneArgument
{
    public class Exponent : IOneArgumentCalculator
    {
        /// <summary>
        /// thois method find exponent of one argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Exp(firstValue);
        }
    }
}
