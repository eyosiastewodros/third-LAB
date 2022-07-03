using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third_LAB
{
    internal class rectangle:Shape
    {
        public int length { get; set; }
        public int width { get; set; }
        public override double Area()
        {
            //throw new NotImplementedException();
            return  length * width;
        }

        public override double perimeter()
        {
            //  throw new NotImplementedException();
            return 2*(length * width);
        }
    }
}
