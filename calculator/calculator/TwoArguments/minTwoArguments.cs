using System;

namespace calculator.TwoArguments
{
    public class MinTwoArguments :ICalculator
    {
        /// <summary>
        /// this method find min argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
           return Math.Min(firstValue,secondValue);
        }
    }
}
