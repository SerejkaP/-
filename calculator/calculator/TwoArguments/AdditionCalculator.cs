namespace calculator.TwoArguments
{
    public class AdditionCalculator : ICalculator
    {
        /// <summary>
        /// this method add together two arguments
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
