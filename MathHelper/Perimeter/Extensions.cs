using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.Perimeter
{
    public static class Extensions
    {
        /// <summary>
        /// Finds the perimeter of a square using its side
        /// </summary>
        /// <param name="s">any side</param>
        /// <returns>Perimeter of a Square</returns>
        public static double Square(this double s) => 4 * s;
        /// <summary>
        /// Finds the perimeter of a rectangle using the length and width
        /// </summary>
        /// <param name="l">length of rectangle</param>
        /// <param name="w">length of width</param>
        /// <returns>Area of rectangle</returns>
        public static double Rectangle(this double l, double w) => 2 * l + 2 * w;
        /// <summary>
        /// Finds the perimeter of a traingle usings its sides
        /// </summary>
        /// <param name="s1">first side of triangle</param>
        /// <param name="s2">second side of triangle</param>
        /// <param name="s3">third side of triangle</param>
        /// <returns></returns>
        public static double Triangle(this double s1, double s2, double s3) => s1 + s2 + s3;
        /// <summary>
        /// Finds perimeter of any shape by giving all te sides in a list format
        /// </summary>
        /// <param name="sides">list of all side values</param>
        /// <returns>perimeter of any shape</returns>
        public static double AnyShape(this List<double> sides)
        {
            double perimeter = 0;
            sides.ForEach(side => perimeter += side);
            return perimeter;
        }
        /// <summary>
        /// Finds the petimeter of a circle
        /// </summary>
        /// <param name="d">diameter of the circle</param>
        /// <param name="pi">pi, the default value is 3.14</param>
        /// <returns></returns>
        public static double Circle(this double d) => Math.PI * d;
    }
}
