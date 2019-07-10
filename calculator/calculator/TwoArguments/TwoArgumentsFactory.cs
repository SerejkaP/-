﻿using System;

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
                case "PowerOfDivision":
                    return new PowerOfDivision();
                case "logTwoArguments":
                    return new LogTwoArguments();
                case "MIN":
                    return new MinTwoArguments();
                case "MAX":
                    return new MaxTwoArguments();
                case "Average":
                    return new Average();
                case "Geometric":
                    return new GeometricMean();
                case "Division":
                    return new DivideCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
