namespace calculator.TwoArguments
{
    public class DivisionCalculator : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}
