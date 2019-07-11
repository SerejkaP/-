using System;

namespace calculator.OneArgument
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method absolute one argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }
    }
}
