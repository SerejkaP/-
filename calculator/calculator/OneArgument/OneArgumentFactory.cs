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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
