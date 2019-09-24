using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathFigures;

namespace MathFiguresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIsTriangle()
        {
            bool result;
            result = Figures.IsTriangle(-5, -5, -5);
            Assert.IsFalse(result, String.Format("Result: {0}", result));

            result = Figures.IsTriangle(1, 1, 0);
            Assert.IsFalse(result, String.Format("Result: {0}", result));

            result = Figures.IsTriangle(1, 1, 1);
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.IsTriangle(3, 4, 5);
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.IsTriangle(8, 8, 4);
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.IsTriangle(8, 1, 1);
            Assert.IsFalse(result, String.Format("Result: {0}", result));

            result = Figures.IsTriangle(8, 4, 4);
            Assert.IsFalse(result, String.Format("Result: {0}", result));
        }

        [TestMethod]
        public void TestMethodTriangleAre()
        {
            bool result;
            result = Figures.TriangleAre(-5, -5, -5)==-1;
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.TriangleAre(1, 1, 0)==-1;
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.TriangleAre(3, 4, 5) == 6;
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.TriangleAre(5, 5, 6) == 12;
            Assert.IsTrue(result, String.Format("Result: {0}", result));
        }

        [TestMethod]
        public void TestMethodCircleAre()
        {
            bool result;
            result = Figures.CircleAre(1) == Math.PI;
            Assert.IsTrue(result, String.Format("Result: {0}", result));
            
        }

        [TestMethod]
        public void TestMethodIsRightTriangle()
        {
            bool result;
            result = Figures.IsRightTriangle(-5, -5, -5);
            Assert.IsFalse(result, String.Format("Result: {0}", result));

            result = Figures.IsRightTriangle(1, 1, 0);
            Assert.IsFalse(result, String.Format("Result: {0}", result));

            result = Figures.IsRightTriangle(3, 4, 5);
            Assert.IsTrue(result, String.Format("Result: {0}", result));

            result = Figures.IsRightTriangle(5, 5, 6);
            Assert.IsFalse(result, String.Format("Result: {0}", result));
        }
    }
}
