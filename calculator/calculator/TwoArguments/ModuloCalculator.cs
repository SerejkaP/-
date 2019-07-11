using System;

namespace calculator.TwoArguments
{
    public class ModuloCalculator :ICalculator
    {
        /// <summary>
        /// this method find remainder of the division
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return firstValue % secondValue;
        }
    }
}
