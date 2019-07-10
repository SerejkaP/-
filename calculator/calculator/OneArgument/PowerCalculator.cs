namespace calculator.OneArgument
{
    class PowerCalculator: IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return firstValue * firstValue;
        }
    }
}
