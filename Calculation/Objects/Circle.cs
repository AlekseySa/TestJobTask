using Calculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Objects
{
    public class Circle : IFigure
    {
        public double AreaOfFigure => CalculationArea.Calculation(Radius);

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
