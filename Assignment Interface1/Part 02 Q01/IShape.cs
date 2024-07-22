using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Interface1.Part_02
{
    internal interface IShape
    {
        decimal Dim01 { get; set; }
        decimal Dim02 { get; set; }
        decimal Area { get; }
        void DisplayShapeInfo();
    }
}
