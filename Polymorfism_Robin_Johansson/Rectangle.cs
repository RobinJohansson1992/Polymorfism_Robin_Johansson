using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism_Robin_Johansson
{
    internal class Rectangle : Geometry
    {
        public double LongSide { get; set; }
        public double ShortSide { get; set; }

        public Rectangle()
        {
            LongSide = 10;
            ShortSide = 6;
        }

        public override double Area()
        {
            return LongSide * ShortSide;
        }

        
    }
}
