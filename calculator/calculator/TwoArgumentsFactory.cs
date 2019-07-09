using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public static class TwoArgumentsFactory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "Plus":
                {
                    return new AdditionCalculator();
                    

                    break;
                }

                case "Minus":
                {
                    return new SubtractionCalculator();
                    break;
                }

                case "Multiply":
                {
                    return new MultiplyCalculator();
                    break;
                }

                case "Divide":
                {
                    return new DivisionCalculator();
                    break;
                }

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
