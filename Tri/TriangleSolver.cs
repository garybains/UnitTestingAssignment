using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public static class TriangleSolver
    {
        public static string Analyze(int a, int b, int c) // 1A
        {
            if (!ValidateTri(a, b, c)) return "Invalid"; // this shouldn't count as a if :/

            int idx = 0; // 2A
            string[] type = new String[] { "Scalene", "Isosceles", "", "Equilateral" };

            if (a == b) // B
                idx++;  // C

            if (b == c) // D
                idx++;  // E

            if (a == c) // F
                idx++;  // G

            return type[idx]; // H
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
