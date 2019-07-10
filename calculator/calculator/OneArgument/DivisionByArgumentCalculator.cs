namespace calculator.OneArgument
{
    public class DivisionByArgumentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return 1 / firstValue;
        }
    }
}
