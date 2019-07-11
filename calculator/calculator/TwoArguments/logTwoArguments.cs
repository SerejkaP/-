using System;

namespace calculator.TwoArguments
{
    public class LogTwoArguments :ICalculator
    {
        /// <summary>
        /// this method find log of second argument by base of first argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            if (firstValue == 1 || firstValue <= 0)
            {
                throw new Exception("Неправильное основание");
            }
            if (secondValue < 0)
            {
                throw new Exception("Аргумент меньше нуля");
            }
            return Math.Log(firstValue, secondValue);
        }
    }
}
