namespace calculator.TwoArguments
{
    class Average: ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue)/2;
        }
    }
}
