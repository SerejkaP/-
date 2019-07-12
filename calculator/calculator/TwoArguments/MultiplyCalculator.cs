namespace calculator.TwoArguments
{
    public class MultiplyCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
    }
}
