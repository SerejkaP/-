using System;

namespace calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Power":
                    return new PowerCalculator();

                case "SquareRoot":
                    return new SquareRootCalculator();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
