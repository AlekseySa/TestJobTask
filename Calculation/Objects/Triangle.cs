using Calculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Objects
{
    public class Triangle : IFigure
    {
        public double AreaOfFigure => CalculationArea.Calculation(SideA, SideB, SideC);

        public bool RightTriangle => CalculationOtherProperties.CheckRightTriangle(SideA, SideB, SideC);
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
