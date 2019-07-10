using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneArgument
{
    class PowerCalculator: IOneArgument
    {
        public double Calculate(double firstValue)
        {
            return firstValue * firstValue;
        }
    }
}
