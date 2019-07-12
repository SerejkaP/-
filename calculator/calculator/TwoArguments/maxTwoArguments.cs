using System;


namespace calculator.TwoArguments
{
    public class MaxTwoArguments : ICalculator
    {
        /// <summary>
        ///  this method find max argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Max(firstValue, secondValue);
        }
    }
}
