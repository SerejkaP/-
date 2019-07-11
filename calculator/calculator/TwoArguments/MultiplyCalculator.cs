namespace calculator.TwoArguments
{
    public class MultiplyCalculator : ICalculator
    {
        /// <summary>
        /// this method multiply two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
