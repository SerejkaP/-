using System;

namespace calculator.TwoArguments
{
    public static class TwoArgumentsFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Plus":
                    return new AdditionCalculator();
                case "Minus":
                    return new SubtractionCalculator();
                case "Multiply":
                    return new MultiplyCalculator();
                case "Divide":
                    return new DivisionCalculator();
                case "PowerTwoArguments":
                    return new PowerTwoArguments();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
