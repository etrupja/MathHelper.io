using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MathHelper.io.Equations
{
    public static class Extensions
    {
        /// <summary>
        /// Finds the distance between two points in the coordinate system.
        /// </summary>
        /// <param name="x1y1">(x1,y1) is a point in the coordinate system</param>
        /// <param name="x2y2">(x2,y2) is a point in the coordinate system</param>
        /// <returns>distance between two points</returns>
        public static double DistanceBetweenTwoPoints(this List<double> x1y1, List<double> x2y2)
        {
            if (x1y1.Count == 2 && x2y2.Count == 2)
            {
                double d1 = x2y2[0] - x1y1[0];
                double d2 = x2y2[1] - x1y1[1];
                return Math.Sqrt(Math.Pow(d1, 2) + Math.Pow(d2, 2));
            }
            return 0;
        }

        /// <summary>
        /// Finds the formula slope of a line by using two points in the coordinate system
        /// </summary>
        /// <param name="x1y1">(x1,y1) is a point in the coordinate system</param>
        /// <param name="x2y2">(x2,y2) is a point in the coordinate system</param>
        /// <returns>formula of the slope of a line for two given points</returns>
        public static string SlopeOfLine(this List<double> x1y1, List<double> x2y2)
        {
            double diffx2x1 = x2y2[0] - x1y1[0];
            if (diffx2x1 == 1)
            {
                return $"m = {x2y2[1]} - y";
            }
            else
            {
                if (diffx2x1 < 0)
                {
                    return $"m = -{x2y2[1]}/{-diffx2x1} + y/{-diffx2x1}";
                }
                return $"m = {x2y2[1]}/{diffx2x1} - y/{diffx2x1}";
            }

        }

        /// <summary>
        /// Finds the quadratic equation (ax^2 + bx + c = 0), where a and b are coefficients and c is a constant
        /// </summary>
        /// <param name="c">constant</param>
        /// <param name="a">coefficient</param>
        /// <param name="b">coefficient</param>
        /// <returns>Quadratic equation using coefficients</returns>
        public static string QuadraticEquation(this double c, double a, double b) => $"y = ({a})x^2 + ({b})x + ({c})";

        /// <summary>
        /// Finds the standard equation of a circle ( (x-h)^2 + (y-k)^2 = r^2 ) where r is the radius and (h,k) the center of the circle
        /// </summary>
        /// <param name="r">radius of the circle</param>
        /// <param name="h">first coordinate of circle's center</param>
        /// <param name="k">second coordinate of circle's center</param>
        /// <returns>Standard equation of circle</returns>
        public static string StandartEquationOfCircle(this double r, double h, double k)
        {
            string firstPart = "";
            string secondPart = "";
            if (h < 0)
            {
                firstPart = $"(x + {-h})^2";
            }
            else if (h > 0)
            {
                firstPart = $"(x - {h})^2";
            }
            else
            {
                firstPart = $"x^2";
            }

            if (k < 0)
            {
                secondPart = $"(y + {-k})^2";
            }
            else if (k > 0)
            {
                secondPart = $"(y - {k})^2";
            }
            else
            {
                secondPart = $"y^2";
            }

            return $"{firstPart} + {secondPart} = {r * r}";
        }

        /// <summary>
        /// Finds the two root values of a 2nd degree equation (ax^2 + bx + c = 0), where a and b are coefficients and c is a constant
        /// </summary>
        /// <param name="c">constant</param>
        /// <param name="a">coefficient</param>
        /// <param name="b">coefficient</param>
        /// <returns>root values of a 2nd degree equation</returns>
        public static List<double> QuadraticFormula(this double c, double a, double b)
        {
            var values = new List<double>();
            var D = Math.Pow(b, 2) - 4 * a * c;
            if (a == 0 || D < 0) return null;

            double firstValue = (-b + Math.Sqrt(D)) / (2 * a);
            double secondValue = (-b - Math.Sqrt(D)) / (2 * a);
            values.Add(firstValue);
            values.Add(secondValue);

            return values;
        }

        /// <summary>
        /// Finds the point-slope equation of a line at a given point
        /// </summary>
        /// <param name="m">value of slope</param>
        /// <param name="x1">first coordinate of the given point</param>
        /// <param name="y1">second coordinate of the given point</param>
        /// <returns></returns>
        public static string PointSlopeEquation(this double m, double x1, double y1)
        {
            string slope = "", coeff = "";

            if (x1 < 0) { slope = $"{m}*(x + {-x1})"; }
            else if (x1 > 0) { slope = $"{m}*(x - {x1})"; }
            else { slope = $"{m}*x"; }

            if (m == 0) { slope = $""; }

            if (y1 < 0) { coeff = $" - {-y1}"; }
            else if (y1 > 0 && m == 0) { coeff = $"{y1}"; }
            else if (y1 > 0) { coeff = $" + {y1}"; }
            else { coeff = $""; }

            return $"y = {slope}{coeff}";
        }

        /// <summary>
        /// Slope-Intercept equation of a line
        /// </summary>
        /// <param name="m">slope</param>
        /// <param name="b">y-intercept</param>
        /// <returns>slope-intercept equation</returns>
        public static string SlopeInterceptEquation(this double m, double b)
        {
            string slope = "", coeff = "";
            if (m == 0) { slope = ""; }
            else { slope = $"{m}x"; }

            if (b < 0) { coeff = $" - {-b}"; }
            else if (b > 0 && m == 0) { coeff = $"{b}"; }
            else if (b > 0) { coeff = $" + {b}"; }
            else { coeff = $""; }

            if (m == 0 && b == 0) return $"y = 0";
            return $"y = {slope}{coeff}";
        }
    }
}
