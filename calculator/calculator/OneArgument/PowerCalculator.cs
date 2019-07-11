namespace calculator.OneArgument
{
    public class PowerCalculator : IOneArgumentCalculator
    {
        /// <summary>
        /// this method squaring argument
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue)
        {
            return firstValue * firstValue;
        }
    }
}
