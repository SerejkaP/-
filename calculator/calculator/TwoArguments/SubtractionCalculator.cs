namespace calculator.TwoArguments
{
    public class SubtractionCalculator :ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
