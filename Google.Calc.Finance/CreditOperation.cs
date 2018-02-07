using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.Calc.Finance
{
    public class CreditOperation : ITUniver.Calc.Core.Interfaces.IOperation
    {
        public int argCount => 2;

        public string Name
        {
            get { return "credit"; }
        }

        public double Exec(double[] args)
        {
            return args.Aggregate((x, y) => (x * 1.094) / y);
        }
    }
}
