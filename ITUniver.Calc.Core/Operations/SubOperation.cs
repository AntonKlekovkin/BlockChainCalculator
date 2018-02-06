using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    class SubOperation : IOperation
    {
        public int argCount => 2;

        public string Name
        {
            get { return "sub"; }
        }

        public double Exec(double[] args)
        {
            return args.Aggregate( (x, y) => x - y );
        }
    }
}
