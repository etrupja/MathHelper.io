using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.Digits
{
    public static class Extensions
    {
        public static bool IsOdd(this int number) => !(number % 2 == 0);
        public static bool IsEven(this int number) => (number % 2 == 0);

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

        public static int Add(this int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public static int Sum(this List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static int Substract(this int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public static double Average(this List<int> numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Count;
        }

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
