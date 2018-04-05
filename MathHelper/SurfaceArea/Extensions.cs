using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.SurfaceArea
{
    public static class Extensions
    {
        /// <summary>
        /// Surface area of a cube
        /// </summary>
        /// <param name="s">any side of the cube</param>
        /// <returns>Surface Area (SA) of a cube</returns>
        public static double Cube(this double s) => 6 * Math.Pow(s, 2);

        /// <summary>
        /// Surfac Area (SA) of a cylinder (lateral)
        /// </summary>
        /// <param name="r">radius of the base of the cylinder</param>
        /// <param name="h">height of the cylinder</param>
        /// <returns></returns>
        public static double Cylinder(this double r, double h) => 2 * Math.PI * r * h;
    }
}
