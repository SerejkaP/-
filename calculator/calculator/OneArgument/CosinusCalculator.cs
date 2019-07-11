using System;

namespace calculator.OneArgument
{
    public class CosinusCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find cosinus of one argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return Math.Cos(firstValue);
        }
    }
}
