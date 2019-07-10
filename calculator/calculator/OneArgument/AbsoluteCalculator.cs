using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgument
{
    public class AbsoluteCalculator : IOneArgumentCalculator
    {
        public double Calculate(double firstValue)
        {
            return Math.Abs(firstValue);
        }
    }
}
