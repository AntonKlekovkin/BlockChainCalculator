using ITUniver.Calc.Core.Interfaces;
using System.Linq;

namespace ITUniver.Calc.Core.Operations
{
    class DivOperation : IOperation
    {
        public int argCount => 2;

        public string Name
        {
            get { return "div"; }
        }

        public double Exec(double[] args)
        {
            return args.Aggregate( (x, y) => x / y );
        }
    }
}
