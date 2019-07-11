namespace calculator.TwoArguments
{
    public class SubtractionCalculator :ICalculator
    {
        /// <summary>
        /// this method subtract two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
