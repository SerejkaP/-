namespace calculator.TwoArguments
{
    class ModuloCalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return firstValue % secondValue;
        }
    }
}
