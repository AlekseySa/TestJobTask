using Calculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Objects
{
    public class UnknownFigure : IFigure
    {
        public double AreaOfFigure => _IFigure.AreaOfFigure;

        private IFigure _IFigure;

        public UnknownFigure(IFigure figure)
        {
            _IFigure = figure;
        }
    }
}
