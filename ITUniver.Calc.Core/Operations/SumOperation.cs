using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    class SumOperation : IOperation
    {
        public int argCount => 2;

        public string Name
        {
            get { return "sum"; }
        }

        public double Exec(double[] args)
        {
            return args.Sum();
        }
    }
}
