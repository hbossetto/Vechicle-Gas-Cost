using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class PHEV : Auto
    {
        public double Range { get; set; }

        public override double Cost
        {
            get
            {
                return (Miles - Range) / MPG * 4;
            }
        }

        public PHEV(string name, double miles, double mpg, double range) : base(name, miles, mpg)
        {
            Range = range;
        }

    }
}
