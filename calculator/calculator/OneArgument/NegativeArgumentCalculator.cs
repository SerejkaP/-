namespace calculator.OneArgument
{
    public class NegativeArgumentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return firstValue = -firstValue;
        }
    }
}
