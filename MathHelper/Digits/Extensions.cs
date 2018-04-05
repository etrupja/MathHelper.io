using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MathHelper.io.Digits
{
    public static class Extensions
    {
        /// <summary>
        /// Checks if a number is Odd
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true, if the number is odd</returns>
        public static bool IsOdd(this int number) => !(number % 2 == 0);
        /// <summary>
        /// Checks if a number is Even
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true, if the number is even</returns>
        public static bool IsEven(this int number) => (number % 2 == 0);

        /// <summary>
        /// Checks if a number is a prime number. Prime numbers are numbers which are divided only by 1 and themselves.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true, if the number is prime number</returns>
        public static bool IsPrime(this int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>Sum of two numbers</returns>
        public static int Add(this int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        /// <summary>
        /// Adds a list of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>Sum of a list of numbers</returns>
        public static int Sum(this List<int> numbers)
        {
            return Enumerable.Sum(numbers);
        }

        /// <summary>
        /// Substracts two numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>the difference between two numbers</returns>
        public static int Substract(this int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        /// <summary>
        /// Divides two numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>raport of two numbers</returns>
        public static double Divide(this int firstNum, int secondNum) => firstNum / secondNum;
        /// <summary>
        /// Mulitplies two numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>Multiplication of two numbers</returns>
        public static int Multiply(this int firstNum, int secondNum) => firstNum * secondNum;

        /// <summary>
        /// Multiplies a list of numbers
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <returns>Multiplication of a list of numbers</returns>
        public static int Multiply(this List<int> numbers)
        {
            int production = (numbers.Count != 0) ? 1 : 0;

            return production * numbers.Aggregate((a, b) => a * b);
        }

        /// <summary>
        /// Average of a list of numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>average of a list of numbers</returns>
        public static double Average(this List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }

        /// <summary>
        /// Arithmetic mean formula
        /// </summary>
        /// <param name="values"></param>
        /// <param name="weights"></param>
        /// <returns>Arithmetic mean formula</returns>
        public static double WeightedAverage(this List<double> values, List<double> weights)
        {
            if (values.Count != weights.Count)
            {
                return 0;
            }

            double valueWeightSum = 0;
            double weightSum = 0;

            for (int i = 0; i < values.Count; i++)
            {
                valueWeightSum += values[i] * weights[i];
            }
            foreach (var weight in weights)
            {
                weightSum += weight;
            }

            return valueWeightSum / weightSum;

        }


    }
}
