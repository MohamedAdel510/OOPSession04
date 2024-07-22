using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Rect : Base
    {
        //public Rect() { }

        public Rect(decimal Dim01, decimal Dim02):base(Dim01, Dim02)
        {

        }
        public override decimal Primeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }
}
