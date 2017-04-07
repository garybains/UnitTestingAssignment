using System;
using NUnit.Framework;
using Triangle;


namespace TestPro
{
    [TestFixture]
    public class UnitTests
    {
        // Cheking for invalid test cases
        [Test]
        public void When_a23_b2_c8_Expect_Invalid()
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(23, 2, 8), "a greater than b + c");
        }
        
        [Test]
        public void When_a2_b23_c8_Expect_Invalid()
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(2, 23, 8), "b greater than a + c");
        }

        [Test]
        public void When_a2_b8_c23_Expect_Invalid()
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(2, 8, 23), "c greater than a + b");
        }

        [Test]
        public void When_a0_Expect_Invalid()
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(0, 2, 100), "a is zero");
        }

        [Test]
        public void When_b0__Invalid()
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(4, 0, 100), "b is zero");
        }

        [Test]
        public void When_c0Invalid()
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(52, 25, 0), "c is zero");
        }

        [Test]
        public void When_a_lt_0_Expect_Invalid() // lt = lesss than
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(-1, 2, 100), "a is less than zero");
        }

        [Test]
        public void When_b_lt_0_Expect_Invalid() // lt = lesss than
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(1, -2, 100), "b is less than zero");
        }

        [Test]
        public void When_c_lt_0__Expect_Invalid() // lt = lesss than
        {
            Assert.AreEqual("Invalid", Triangle.TriangleSolver.Analyze(1, 2, -54), "c is less than zero");
        }


        // Checking for Equalateral
        [Test]
        public void When_a5_b5_c5_Expect_Equilateral()
        {
            Assert.AreEqual("Equilateral", Triangle.TriangleSolver.Analyze(5, 5, 5), "a = b = c = 5");
        }

        [Test]
        public void When_a1024_b1024_c1024_Expect_Equilateral()
        {
            Assert.AreEqual("Equilateral", Triangle.TriangleSolver.Analyze(1024, 1024, 1024), "a = b = c = 1024");
        }

        // Checking for Isosceles
        [Test]
        public void When_a5_b5_c1_Expect_Isosceles()
        {
            Assert.AreEqual("Isosceles", Triangle.TriangleSolver.Analyze(5, 5, 1), "a = b = 5 != c = 1");
        }

        [Test]
        public void When_a55_b25_c55_Expect_Isosceles()
        {
            Assert.AreEqual("Isosceles", Triangle.TriangleSolver.Analyze(55, 25, 55), "a = c = 55 != b = 25");
        }

        [Test]
        public void When_a51_b33_c33_Expect_Isosceles()
        {
            Assert.AreEqual("Isosceles", Triangle.TriangleSolver.Analyze(51, 33, 33), "b = c = 33 != a = 51");
        }

        [Test]
        public void When_a10_b7_c4_Expect_Scalene()
        {
            Assert.AreEqual("Scalene", Triangle.TriangleSolver.Analyze(10, 7, 4), "a = 10, b = 7, c = 4 Scalene Traingle1");
        }

        [Test]
        public void When_a356_b332_c397_Expect_Scalene()
        {
            Assert.AreEqual("Scalene", Triangle.TriangleSolver.Analyze(356, 332, 397), "a = 356, b = 332, c = 397 Scalene Traingle2");
        }

        [Test]
        public void When_a110_b210_c310_Expect_Scalene()
        {
            Assert.AreEqual("Scalene", Triangle.TriangleSolver.Analyze(110, 210, 310), "a = 110, b = 210, c = 310 Scalene Traingle3");
        }
        
    }
}
