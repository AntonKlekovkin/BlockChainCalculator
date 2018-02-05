using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class Calc
    {
        public double sub(double x, double y)
        {
            return x - y;
        }
        public double sum(double x, double y)
        {
            return x + y;
        }
        public double mul(double x, double y)
        {
            return x * y;
        }
        public double div(double x, double y)
        {
            return x / y;
        }
        public double sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
