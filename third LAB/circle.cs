using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_LAB
{
    internal class circle : Shape
    {

        public int Radius { get; set; }
        public override double Area()
        {
            //throw new NotImplementedException();
            return Shape.pi * Radius * Radius;
        }

        public override double perimeter()
        {
            //  throw new NotImplementedException();
            return Shape.pi * Radius*2;
        }
    }
}
