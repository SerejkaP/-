namespace calculator.TwoArguments
{
    public class Average : ICalculator
    {
        /// <summary>
        /// this method find average of two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue) / 2;
        }
    }
}
