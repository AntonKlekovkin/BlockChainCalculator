using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    class MulOperation : IOperation
    {
        public int argCount => 2;

        public string Name
        {
            get { return "mul"; }
        }

        public double Exec(double[] args)
        {
            return args.Aggregate( (x, y) => x * y );
        }
    }
}
