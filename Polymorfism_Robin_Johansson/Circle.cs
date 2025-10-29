using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Robin_Johansson
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 5;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI; 
        }
    }
}
