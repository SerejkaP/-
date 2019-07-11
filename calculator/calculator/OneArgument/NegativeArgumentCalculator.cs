namespace calculator.OneArgument
{
    public class NegativeArgumentCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method reverse argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return firstValue = -firstValue;
        }
    }
}
