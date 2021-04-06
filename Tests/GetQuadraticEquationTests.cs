using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.MironGurevich;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.MironGurevich.Tests
{
    [TestClass()]
    public class GetQuadraticEquationTests
    {
        [TestMethod()]
        public void SolveTest1()
        {
            float a = 0;
            float b = -5;
            float c = 2;
            List<float> expected = new List<float>() { 0.4f };

            GetQuadraticEquation d = new GetQuadraticEquation();
            List<float> actual = d.Solve(a, b, c);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SolveTest2()
        {
            float a = 3;
            float b = -5;
            float c = 2;
            List<float> expected = new List<float>() {1, 0.6666667f };

            GetQuadraticEquation d = new GetQuadraticEquation();
            List<float> actual = d.Solve(a, b, c);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod()]
        [ExpectedException(typeof(MironException))]
        public void SolveExTest()
        {

            GetQuadraticEquation c = new GetQuadraticEquation();
            List<float> actual1 = c.Solve(0, 0, 1);
        }
    }
}