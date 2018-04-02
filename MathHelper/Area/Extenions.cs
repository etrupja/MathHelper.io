using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.Area
{
    public static class Extenions
    {
        /// <summary>
        /// Area of a Square
        /// </summary>
        /// <param name="s">s = any side of the square</param>
        /// <returns>Area of a Square</returns>
        public static double Square(this double s)
        {
            return s * s;
        }

        /// <summary>
        /// Area of a Rectange
        /// </summary>
        /// <param name="l">length</param>
        /// <param name="w">width</param>
        /// <returns>Area of a Rectange</returns>
        public static double Rectange(this double l, double w)
        {
            return l * w;
        }

        /// <summary>
        /// Area of a Parallelogram
        /// </summary>
        /// <param name="b">base</param>
        /// <param name="h">height</param>
        /// <returns>Area of a Parallelogram</returns>
        public static double Parallelogram(this double b, double h)
        {
            return b* h;
        }

        /// <summary>
        /// Area of a Triangle
        /// </summary>
        /// <param name="b">base of the triangle</param>
        /// <param name="h">height of the triangle</param>
        /// <returns>Area of a Triangle</returns>
        public static double Triangle(this double b, double h)
        {
            return 0.5 * b * h;
        }

        /// <summary>
        /// Area of a Circle
        /// </summary>
        /// <param name="r">radius of the circle</param>
        /// <param name="pi">pi, the default value is 3.14</param>
        /// <returns>Area of the Circle</returns>
        public static double Circle(this double r, double pi = 3.14)
        {
            return pi * r * r;
        }

        /// <summary>
        /// Area of a Trapezoid
        /// </summary>
        /// <param name="h">heigh of trapezoid</param>
        /// <param name="b1">first base of trapezoid</param>
        /// <param name="b2">second base of trapezoid</param>
        /// <returns>Area of a Trapezoid</returns>
        public static double Trapezoid(this double h, double b1, double b2)
        {
            return 0.5 * (b1 + b2) * h;
        }

        /// <summary>
        /// Area/Surface of a sphere
        /// </summary>
        /// <param name="r">radius of the sphere</param>
        /// <param name="pi">pi, the default value is 3.14</param>
        /// <returns></returns>
        public static double Sphere(this double r, double pi = 3.14)
        {
            return 4 * pi * r * r;
        }
    }
}
