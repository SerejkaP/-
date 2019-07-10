namespace calculator.TwoArguments
{
    class SubtractionCalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
    }
}
