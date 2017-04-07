using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c)
        {
            if (!ValidateTri(a, b, c)) return "Invalid"; // this shouldn't count as a if :/

            int idx = 0;
            if (a == b)
                idx++;

            if (b == c)
                idx++;

            if (a == c)
                idx++;

            string[] type = new String[] { "Scalene", "Isosceles", "", "Equilateral" };

            return type[idx];
        }
        static bool ValidateTri(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a > (b + c) || b > (a + c) || c > (a + b))
            {
                return false;
            }
            return true;
        }
    }
}
