using System;

namespace calculator.TwoArguments
{
    public class PowerTwoArguments : ICalculator
    {
        /// <summary>
        ///  this method find first argument to second degree
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return Math.Pow(firstValue,secondValue); 
        }
    }
}
