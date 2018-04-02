using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.Volume
{
    public static class Extensions
    {
        /// <summary>
        /// Finds the volume of a cube
        /// </summary>
        /// <param name="s">any side</param>
        /// <returns>return the volume of a cube</returns>
        public static double Cube(this double s) => Math.Pow(s, 3);
        /// <summary>
        /// Finds the volume of a Rectangular Container
        /// </summary>
        /// <param name="l">length</param>
        /// <param name="w">width</param>
        /// <param name="h">height</param>
        /// <returns>volume of a rectangular container</returns>
        public static double Rectangular(this double l, double w, double h) => l * w * h;
        /// <summary>
        /// Finds the volume of a Square Pyramid
        /// </summary>
        /// <param name="b">base length</param>
        /// <param name="h">height</param>
        /// <returns>volume of a square pyramid</returns>
        public static double SquarePyramid(this double b, double h) => (1 / 3) * Math.Pow(b, 2) * h;
        /// <summary>
        /// Finds the volume of a cylinder
        /// </summary>
        /// <param name="r">radius of the base</param>
        /// <param name="h">height</param>
        /// <param name="pi">pi, by default pi=3.14</param>
        /// <returns>volume of a cylinder</returns>
        public static double Cylinder(this double r, double h, double pi = 3.14) => pi * Math.Pow(r, 2) * h;
        /// <summary>
        /// Finds the volume of a cone
        /// </summary>
        /// <param name="r">radius of the base</param>
        /// <param name="h">height</param>
        /// <param name="pi">pi, by default pi=3.14</param>
        /// <returns>volume of the cone</returns>
        public static double Cone(this double r, double h, double pi = 3.14) => (1 / 3) * pi * Math.Pow(r, 2) * h;
        /// <summary>
        /// Finds the volume of a sphere
        /// </summary>
        /// <param name="r">radius of a sphere</param>
        /// <param name="pi">pi, by default pi=3.14</param>
        /// <returns>volume of a sphere</returns>
        public static double Sphere(this double r, double pi = 3.14) => (4 / 3) * pi * Math.Pow(r, 3);
        /// <summary>
        /// Finds the volume of a Right Circular Cylinder
        /// </summary>
        /// <param name="r">radius</param>
        /// <param name="h">height</param>
        /// <param name="pi">pi, by default pi=3.14</param>
        /// <returns>volume of a right circular cylinder</returns>
        public static double RightCircularCylinder(this double r, double h, double pi = 3.14) => pi * Math.Pow(r, 2) * h;
    }
}
