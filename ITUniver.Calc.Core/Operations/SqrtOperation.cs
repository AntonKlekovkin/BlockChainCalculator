using ITUniver.Calc.Core.Interfaces;
using System;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    class SqrtOperation : IOperation
    {
        public int argCount => 1;

        public string Name
        {
            get { return "sqrt"; }
        }

        public double Exec(double[] args)
        {
            return Math.Sqrt(args[0]);
        }
    }
}
