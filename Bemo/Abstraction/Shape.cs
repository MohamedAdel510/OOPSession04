using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    abstract class Shape
    {
        //Prperties
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        public abstract decimal Primeter { get; }
        
        //Constructors
        public Shape()
        {
            Dim01 = 0.0m;
            Dim02 = 0.0m;
        }
        public Shape(decimal Dim01, decimal Dim02)
        {
            this.Dim01 = Dim01;
            this.Dim02 = Dim02;
        }

        public abstract decimal CalcArea();
    }
}
