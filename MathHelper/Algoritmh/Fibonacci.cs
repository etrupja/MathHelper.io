using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.Algoritmh
{
    public static class Fibonacci
    {

        /// <summary>
        /// Calculates Fibonacci numbers
        /// </summary>
        /// <param name="count">Count of requested fibonacci numbers. Max is 91.</param>
        /// <returns></returns>
        public static IEnumerable<ulong> Fibs(sbyte count = 1)
        {
            if (count == 0)
                throw new ArgumentException($"{nameof(Fibonacci)} {nameof(Fibs)} says: Minimum count is 1!");

            checked
            // count 92 will throw overflow exception here
            {
                ulong previous = 1, current = 1;

                for (sbyte i = 0; i < count; i++)
                {
                    yield return previous;

                    ulong newFib = previous + current;

                    previous = current;

                    current = newFib;
                }
            }
        }
    }
}
