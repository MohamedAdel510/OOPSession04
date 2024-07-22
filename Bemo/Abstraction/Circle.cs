using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Circle : Shape
    {
        //public Circle() { }

        public Circle(decimal Radius) :base(Radius, Radius)
        {

        }
        public override decimal Primeter {
            get { return 2 * 3.14m * Dim01; }
        }

        public override decimal CalcArea()
        {
            return 3.14m * Dim01 * Dim02;
        }
    }
}
