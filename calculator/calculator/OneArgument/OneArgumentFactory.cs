using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgument
{
    public static class OneArgumentFactory
    {
        public static IOneArgument CreateCalculator(string name)
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
