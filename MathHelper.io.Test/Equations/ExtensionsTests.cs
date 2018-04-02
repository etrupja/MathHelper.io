using MathHelper.io.Equations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MathHelper.io.Test
{
    [TestClass]
    public class ExtensionsEquationsTests
    {
        [TestMethod]
        public void TestDistanceBetweenTwoPoints()
        {
            var px1 = new List<double>() { 3, 2 };
            var py1 = new List<double>() { 9, 7 };
            var d1 = px1.DistanceBetweenTwoPoints(py1);
            Assert.IsTrue(Math.Sqrt(61) == d1);

            var px2 = new List<double>() { -1, 2 };
            var py2 = new List<double>() { 2, 1 };
            var d2 = px2.DistanceBetweenTwoPoints(py2);
            Assert.IsTrue(Math.Sqrt(10)  == d2);
        }

        [TestMethod]
        public void TestSlopeOfLine()
        {
            var px1 = new List<double>() { 1, 2 };
            var py1 = new List<double>() { 2, 3 };
            var m1 = px1.SlopeOfLine(py1);
            Assert.IsTrue("m = 3 - y" == m1);

            var px2 = new List<double>() { 4, 2 };
            var py2 = new List<double>() { 1, 1 };
            var m2 = px2.SlopeOfLine(py2);
            Assert.IsTrue($"m = -1/3 + y/3" == m2);

            var px3 = new List<double>() { 1, 2 };
            var py3 = new List<double>() { 4, 1 };
            var m3 = px3.SlopeOfLine(py3);
            Assert.IsTrue($"m = 1/3 - y/3" == m3);
        }

        [TestMethod]
        public void TestQuadraticEquation()
        {
            double a1 = 1, b1 = 2, c1 = 3;
            double a2 = 0, b2 = 1, c2 = -2;
            double a3 = -11, b3 = -2, c3 = -3;
            double a4 = 1, b4 = 0, c4 = -3;
            double a5 = -4, b5 = 0, c5 = 0;

            string eq1 = c1.QuadraticEquation(a1, b1);
            string eq2 = c2.QuadraticEquation(a2, b2);
            string eq3 = c3.QuadraticEquation(a3, b3);
            string eq4 = c4.QuadraticEquation(a4, b4);
            string eq5 = c5.QuadraticEquation(a5, b5);

            Assert.AreEqual(eq1, $"y = ({a1})x^2 + ({b1})x + ({c1})");
            Assert.AreEqual(eq2, $"y = ({a2})x^2 + ({b2})x + ({c2})");
            Assert.AreEqual(eq3, $"y = ({a3})x^2 + ({b3})x + ({c3})");
            Assert.AreEqual(eq4, $"y = ({a4})x^2 + ({b4})x + ({c4})");
            Assert.AreEqual(eq5, $"y = ({a5})x^2 + ({b5})x + ({c5})");
        }


        [TestMethod]
        public void TestStandartEquationOfCircle()
        {
            double h1 = 4, k1 = 5, r1 = 2;
            double h2 = -4, k2 = 5, r2 = 2;
            double h3 = 0, k3 = 5, r3 = 2;
            double h4 = 4, k4 = -5, r4 = 3;
            double h5 = 4, k5 = 0, r5 = 2;
            double h6 = 4, k6 = 5, r6 = -2;
            double h7 = 4, k7 = 5, r7 = 0;

            var eq1 = r1.StandartEquationOfCircle(h1, k1);
            var eq2 = r2.StandartEquationOfCircle(h2, k2);
            var eq3 = r3.StandartEquationOfCircle(h3, k3);
            var eq4 = r4.StandartEquationOfCircle(h4, k4);
            var eq5 = r5.StandartEquationOfCircle(h5, k5);
            var eq6 = r6.StandartEquationOfCircle(h6, k6);
            var eq7 = r7.StandartEquationOfCircle(h7, k7);

            Assert.IsTrue($"(x - 4)^2 + (y - 5)^2 = 4" == eq1);
            Assert.IsTrue($"(x + 4)^2 + (y - 5)^2 = 4" == eq2);
            Assert.IsTrue($"x^2 + (y - 5)^2 = 4" == eq3);
            Assert.IsTrue($"(x - 4)^2 + (y + 5)^2 = 9" == eq4);
            Assert.IsTrue($"(x - 4)^2 + y^2 = 4" == eq5);
            Assert.IsTrue($"(x - 4)^2 + (y - 5)^2 = 4" == eq6);
            Assert.IsTrue($"(x - 4)^2 + (y - 5)^2 = 0" == eq7);
        }

        [TestMethod]
        public void TestQuadraticFormula()
        {
            double a1 = 2, b1 = 5, c1 = 2;
            double a2 = 3, b2 = 5, c2 = 3;
            double a3 = 1, b3 = 4, c3 = 3;
            double a4 = 1, b4 = -4, c4 = 3;

            var v1 = c1.QuadraticFormula(a1, b1);
            var v2 = c2.QuadraticFormula(a2, b2);
            var v3 = c3.QuadraticFormula(a3, b3);
            var v4 = c4.QuadraticFormula(a4, b4);

            Assert.IsTrue(-0.5 == v1[0] && -2 == v1[1]);
            Assert.IsNull(v2);
            Assert.IsTrue(-1 == v3[0] && -3 == v3[1]);
            Assert.IsTrue(3 == v4[0] && 1 == v4[1]);
        }

        [TestMethod]
        public void TestPointSlopeEquation()
        {
            double m1 = 4, x1 = 5, y1 = 2;
            double m2 = -4,x2 = 5, y2 = 2;
            double m3 = 0, x3 = 5, y3 = 2;
            double m4 = 4, x4 = -5,y4 = 3;
            double m5 = 4, x5 = 0, y5 = 2;
            double m6 = 4, x6 = 5, y6 = -2;
            double m7 = 4, x7 = 5, y7 = 0;

            string eq1 = m1.PointSlopeEquation(x1, y1);
            string eq2 = m2.PointSlopeEquation(x2, y2);
            string eq3 = m3.PointSlopeEquation(x3, y3);
            string eq4 = m4.PointSlopeEquation(x4, y4);
            string eq5 = m5.PointSlopeEquation(x5, y5);
            string eq6 = m6.PointSlopeEquation(x6, y6);
            string eq7 = m7.PointSlopeEquation(x7, y7);

            Assert.IsTrue("y = 4*(x - 5) + 2" == eq1);
            Assert.IsTrue("y = -4*(x - 5) + 2" == eq2);
            Assert.IsTrue("y = 2" == eq3);
            Assert.IsTrue("y = 4*(x + 5) + 3" == eq4);
            Assert.IsTrue("y = 4*x + 2" == eq5);
            Assert.IsTrue("y = 4*(x - 5) - 2" == eq6);
            Assert.IsTrue("y = 4*(x - 5)" == eq7);
        }

        [TestMethod]
        public void TestSlopeInterceptEquation()
        {
            double m1 = 4, b1 = 5;
            double m2 =-4, b2 = 5;
            double m3 = 0, b3 = 5;
            double m4 = 4, b4 = -5;
            double m5 = 4, b5 = 0;

            string eq1 = m1.SlopeInterceptEquation(b1);
            string eq2 = m2.SlopeInterceptEquation(b2);
            string eq3 = m3.SlopeInterceptEquation(b3);
            string eq4 = m4.SlopeInterceptEquation(b4);
            string eq5 = m5.SlopeInterceptEquation(b5);

            Assert.IsTrue("y = 4x + 5" == eq1);
            Assert.IsTrue("y = -4x + 5" == eq2);
            Assert.IsTrue("y = 5" == eq3);
            Assert.IsTrue("y = 4x - 5" == eq4);
            Assert.IsTrue("y = 4x" == eq5);
        }
    }
}
