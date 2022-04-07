using System;

namespace Calculation
{
    public static class CalculationArea
    {
        /// <summary>
        /// Calculation of circle area.
        /// </summary>
        /// <param name="radius">Radius of circle</param>
        /// <returns></returns>
        public static double Calculation(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Calculation of triangle area.
        /// </summary>
        /// <param name="sideA">"a" triangle side</param>
        /// <param name="sideB">"b" triangle side</param>
        /// <param name="sideC">"c" triangle side</param>
        /// <returns></returns>
        public static double Calculation(double sideA, double sideB, double sideC)
        {
            double perimeter = (sideA + sideB + sideC) / 2;

            return Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
        }
    }
}
