using MathHelper.io.Digits;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MathHelper.io.Test
{
    [TestClass]
    public class ExtensionsTests
    {
        [DataTestMethod]
        [DataRow(5)]
        [DataRow(17)]
        [DataRow(111113)]
        [DataRow(3547)]
        public void TestIsOdd(int input) => Assert.IsTrue(input.IsOdd());

        [DataTestMethod]
        [DataRow(4)]
        [DataRow(16)]
        [DataRow(111114)]
        [DataRow(3546)]
        public void TestIsNotOdd(int input) => Assert.IsFalse(input.IsOdd());

        [DataTestMethod]
        [DataRow(4)]
        [DataRow(16)]
        [DataRow(111114)]
        [DataRow(3546)]
        public void TestIsEven(int input) => Assert.IsTrue(input.IsEven());

        [DataTestMethod]
        [DataRow(5)]
        [DataRow(17)]
        [DataRow(111113)]
        [DataRow(3547)]
        public void TestIsNotEven(int input) => Assert.IsFalse(input.IsEven());

        [DataTestMethod]
        [DataRow(2)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(97)]
        [DataRow(127)]
        public void TestIsPrime(int input) => Assert.IsTrue(input.IsPrime());


        [DataTestMethod]
        [DataRow(4)]
        [DataRow(16)]
        [DataRow(22)]
        [DataRow(22222222)]
        [DataRow(128)]
        public void TestIsNotPrime(int input) => Assert.IsFalse(input.IsPrime());


        [DataTestMethod]
        [DataRow(2, 8, 10)]
        [DataRow(-2, 10, 8)]
        public void TestAdd(int value1, int value2, int result) => Assert.IsTrue(result == value1.Add(value2));


        [TestMethod]
        public void TestSum()
        {
            List<int> sum20 = new List<int>() { 2, 10, 8 };
            Assert.IsTrue(20 == sum20.Sum());

            List<int> sumNot20 = new List<int>() { 2, 13, 8 };
            Assert.IsFalse(20 == sumNot20.Sum());
        }

        [DataTestMethod]
        [DataRow(8, 4, 4)]
        [DataRow(8, -92, 100)]
        [DataRow(8, 8, 0)]
        public void TestSubstract(int value1, int value2, int result) => Assert.IsTrue(result == value1.Substract(value2));

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
            Assert.IsTrue(5.5 == new List<double> { 8, 4 }.WeightedAverage(new List<double> { 1.5, 2.5 }));
            Assert.IsFalse(5.5 == new List<double> { 8, 4 }.WeightedAverage(new List<double> { 1.5, 2.6 }));
        }
    }
}
