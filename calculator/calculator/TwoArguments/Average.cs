using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace calculator.TwoArguments
{
    class Average: ICalculator
    {
        public double Calculate(double firstValue, double secondValue)
        {
            return (firstValue + secondValue)/2;
        }
    }
}
