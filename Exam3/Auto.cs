using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Auto : Vehicle
    {
        public double Gallons
        {
            get
            {
                return Miles / MPG;
            }
        }

        public override double Speed
        {
            get => 65;
        }

        public double MPG { get; set; } 
        public virtual double Cost
        {
            get
            {
                return Miles / MPG * 4.00;
            }
        }

        public Auto(string name, double miles, double mpg) : base(name, miles)
        {
            MPG = mpg;
        }
    }
}
