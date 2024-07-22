using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    abstract class Base : Shape
    {
        public Base() { }
        public Base(decimal Dim01, decimal Dim02) : base(Dim01, Dim02) { }
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
