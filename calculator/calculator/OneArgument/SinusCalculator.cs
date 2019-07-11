using System;

namespace calculator.OneArgument
{
    public class SinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find sinus of argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Sin(firstValue);
        }
    }
}
