using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Vehicle
    {
        public string Name { get; set; } // Vehicle Name
        public virtual double Speed { get; } // Average Speed
        public double Miles { get; set; } // Miles Travled
        public double Hours
        {
            get
            {
                return Miles / Speed;
            }
        }

        public Vehicle(string name, double miles)
        {
            Name = name;
            Miles = miles;
        }
    }
}
