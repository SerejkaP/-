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
                case "TwoPowerValues":
                    return new TwoPowerValues();
                case "Log10":
                    return new LogOfTenCalculator();


                case "TenPowerValues":
                    return new TenPowerValues();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
