using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>() 
            {
                new Bicycle("Bicycle", 60, 150),
                new Auto("Cadillac", 60, 20),
                new PHEV("Chevy Volt", 60, 40, 39)
            };

            Console.WriteLine("Name            Hours      Gallons        Cost");
            Console.WriteLine("------         --------   ----------     -----");
            foreach (Vehicle v in vehicles)
            {
                if (v is Bicycle)
                {
                    Console.WriteLine($"{v.Name:N}            {v.Hours:N}");
                }
                else
                {
                    Auto va = (Auto)v;
                    Console.WriteLine($"{va.Name:N}            {va.Hours:N}      {va.Gallons:N}        {va.Cost:C}");
                };
            }
            Console.ReadKey();
        }
    }
}
