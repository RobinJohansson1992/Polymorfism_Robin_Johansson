using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Robin_Johansson
{
    internal class Triangle : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
            Base = 6;
            Height = 7;
        }

        public override double Area()
        {
            return (Base * Height) / 2;
        }
    }
}
