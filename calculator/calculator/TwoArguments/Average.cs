namespace calculator.TwoArguments
{
    public class Average : ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue) / 2;
        }
    }
}
