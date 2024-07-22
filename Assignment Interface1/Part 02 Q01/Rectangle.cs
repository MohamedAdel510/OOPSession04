using Assignment_Interface1.Part_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface1.Part_02_Q01
{
    internal class Rectangle:IRectangle
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public Rectangle(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        public decimal Area
        {
            get { return Dim01 * Dim02; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Dim01: {Dim01}");
            Console.WriteLine($"Dim02: {Dim02}");
            Console.WriteLine($"Rectangle Area: {Area}");
            Console.WriteLine();
        }
    }
}
