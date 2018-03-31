using MathHelper.io.Digits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MathHelper.io.Test
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void TestIsOdd()
        {
            int x = 5;
            bool isOdd = x.IsOdd();
            Assert.IsTrue(isOdd);
            Assert.IsFalse(16.IsOdd());
            Assert.IsTrue(111113.IsOdd());
        }

        [TestMethod]
        public void TestIsEven()
        {
            int x = 6;
            bool isEven = x.IsEven();
            Assert.IsTrue(isEven);
            Assert.IsTrue(16.IsEven());
            Assert.IsFalse(111113.IsEven());
        }

        [TestMethod]
        public void TestIsPrime()
        {
            Assert.IsTrue(2.IsPrime());
            Assert.IsTrue(11.IsPrime());
            Assert.IsTrue(13.IsPrime());
            Assert.IsTrue(97.IsPrime());
            Assert.IsTrue(127.IsPrime());
            Assert.IsFalse(16.IsPrime());
        }

        [TestMethod]
        public void TestAdd()
        {
            Assert.IsTrue(10 == 2.Add(8));
            Assert.IsTrue(-8 == 2.Add(-10));
        }


        [TestMethod]
        public void TestSum()
        {
            List<int> sum20 = new List<int>(){ 2, 10, 8 };
            Assert.IsTrue(20 == sum20.Sum());

            List<int> sumNot20 = new List<int>() { 2, 13, 8 };
            Assert.IsFalse(20 == sumNot20.Sum());
        }

        [TestMethod]
        public void TestSubstract()
        {
            Assert.IsTrue(4 == 8.Substract(4));
            Assert.IsTrue(100 == 8.Substract(-92));
            Assert.IsFalse(4 == 8.Substract(8));
        }

        [TestMethod]
        public void TestAverage()
        {
            Assert.IsTrue(10 == new List<int>() { 2, 18 }.Average());
            Assert.IsTrue(20 == new List<int>() { 20, 18, 22 }.Average());
            Assert.IsFalse(2 == new List<int>() { 20, 18, 22 }.Average());

        }

        [TestMethod]
        public void TestWeightedAverage()
        {
            Assert.IsTrue(5.5 == new List<double> { 8,4}.WeightedAverage(new List<double> {1.5,2.5}));
            Assert.IsFalse(5.5 == new List<double> { 8,4}.WeightedAverage(new List<double> {1.5,2.6}));
        }
    }
}
