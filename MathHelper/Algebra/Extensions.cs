using System;
using System.Collections.Generic;
using System.Text;

namespace MathHelper.io.Algebra
{
    public static class Extensions
    {
        public static int DiffSq(this int a, int b) => (a - b) * (a + b);
    }
}
