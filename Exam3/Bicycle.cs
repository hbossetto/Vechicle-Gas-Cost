using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Bicycle : Vehicle
    {
        public double Weight { get; set; }

        public override double Speed
        {
            get => 2000 / Weight;
        }
        
        public Bicycle(string name, double miles, double weight) : base(name, miles)
        {
            Weight = weight;
        }
    }
}
