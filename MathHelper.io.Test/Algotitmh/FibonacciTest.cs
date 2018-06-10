using MathHelper.io.Algoritmh;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathHelper.io.Test.Algotitmh
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Fibonacci_Test()
        {
            var expected = new List<ulong> { 1, 1, 2, 3, 5, 8, 13, 21 };

            var actual = Fibonacci.Fibs(8).ToList();

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void Fibonacci_Max_Test()
        {
            var result = Fibonacci.Fibs(91);

            Console.WriteLine(result.Last());
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Fibonacci_Max_Fail_Test()
        {
            var result = Fibonacci.Fibs(92);

            Console.WriteLine(result.Last());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Fibonacci_Count_Fail_Test()
        {
            Fibonacci.Fibs(0).First();
        }
    }
}
