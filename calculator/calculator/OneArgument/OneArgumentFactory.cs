using System;

namespace calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        /// <summary>
        /// factory for working with one argument
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Power":
                    return new PowerCalculator();
                case "SquareRoot":
                    return new SquareRootCalculator();
                case "Sinus":
                    return new SinusCalculator();
                case "Cosinus":
                    return new CosinusCalculator();
                case "LogOfExp":
                    return new LogOneArgument();
                case "Exponent":
                    return new Exponent();
                case "Tangent":
                    return new TangentCalculator();
                case "TwoPowerValues":
                    return new TwoPowerValues();
                case "Log10":
                    return new LogOfTenCalculator();
                case "Log2":
                    return new LogOfTwoCalculator();
                case "DivisionByArgument":
                    return new DivisionByArgumentCalculator();
                case "Absolute":
                    return new AbsoluteCalculator();
                case "Negative":
                    return new NegativeArgumentCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
