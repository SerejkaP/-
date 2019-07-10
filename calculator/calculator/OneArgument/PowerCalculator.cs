namespace calculator.OneArgument
{
    public class PowerCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return firstValue * firstValue;
        }
    }
}
