using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface1.Part_02
{
    internal class Circle : ICircle
    {
        public decimal Dim01 { get ; set ; }
        public decimal Dim02 { get ; set ; }

        public Circle(decimal Radius) {
            Dim01 = Dim02 = Radius;
        }
        public decimal Area {
            get { return 3.14m * Dim01 * Dim02; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius: {Dim01}");
            Console.WriteLine($"Circle Area: {Area}");
            Console.WriteLine();
        }
    }
}
