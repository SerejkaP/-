using System;

namespace calculator.OneArgument
{
    public class SquareRootCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method find square root of argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            if (firstValue < 0)
            {
                throw new Exception("Отрицательное значение под корнем");
            }
            return Math.Sqrt(firstValue);
        }
    }
}
