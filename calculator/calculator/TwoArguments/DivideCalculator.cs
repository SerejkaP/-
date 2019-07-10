namespace calculator.TwoArguments
{
    public class DivideCalculator:ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (int)(firstValue / secondValue);
        }
    }
}
