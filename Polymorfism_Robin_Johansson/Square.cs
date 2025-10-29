using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Robin_Johansson
{
    internal class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 7;
        }

        public override double Area()
        {
            return Side * Side;
        }

    }
}
