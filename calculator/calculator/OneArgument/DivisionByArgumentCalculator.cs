using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgument
{
    public class DivisionByArgumentCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return 1 / firstValue;
        }
    }
}
