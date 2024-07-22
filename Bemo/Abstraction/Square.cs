using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Square : Base
    {
        //public Square() { }

        public Square(decimal Dim):base(Dim, Dim) { }
        public override decimal Primeter 
        { 
            get { return Dim01 * 4; } 
        }
    }
}
