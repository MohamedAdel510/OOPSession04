using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal class Triangle:Shape
    {
        public decimal Dim03 {  get; set; }

        public Triangle(decimal Dim01, decimal Dim02, decimal Dim03):base(Dim01, Dim02)
        {
            this.Dim03 = Dim03;
        }
        public override decimal Primeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }
}
