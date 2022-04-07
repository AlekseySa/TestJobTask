using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation
{
    public static class CalculationOtherProperties
    {
        /// <summary>
        /// Check if triangle is rectangular.
        /// </summary>
        /// <param name="sideA">"a" triangle side</param>
        /// <param name="sideB">"b" triangle side</param>
        /// <param name="sideC">"c" triangle side</param>
        /// <returns></returns>
        public static bool CheckRightTriangle(double sideA, double sideB, double sideC)
        {
            if (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
                || Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)
                || Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2))
                return true;
            else
                return false;
        }
    }
}
