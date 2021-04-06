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
    public class GetLinearEquationTests
    {
        [TestMethod()]
        public void RootTestRet2()
        {
            //arrange
            float x1 = 10;
            float y1 = 20;
            float expected1 = -2;

            
            //act
            GetLinearEquation c = new GetLinearEquation();
            float actual1 = c.Root(x1, y1);
            

            //assert
            Assert.AreEqual(expected1, actual1);
            
        }
        [TestMethod]
        public void RootTestRet05()
        {
            //arr
            float x2 = -2;
            float y2 = 1;
            float expected2 = 0.5f;

            //act
            GetLinearEquation c = new GetLinearEquation();
            float actual2 = c.Root(x2, y2);

            //assert
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod()]
        [ExpectedException(typeof(MironException))]
        public void RootExTest()
        {
           
            GetLinearEquation c = new GetLinearEquation();
            float actual1 = c.Root(0, 1);
        }
    }
}