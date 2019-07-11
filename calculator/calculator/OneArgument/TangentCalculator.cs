using System;

namespace calculator.OneArgument
{
    public class TangentCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find tangent of argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Tan(firstValue);
        }
    }
}
