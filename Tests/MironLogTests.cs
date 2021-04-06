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
    public class MironLogTests
    {
        [TestMethod()]
        public void GetInstanceTest()
        {
            Assert.IsInstanceOfType(MironLog.GetInstance(), typeof(object));

        }

        [TestMethod()]
        public void LogTest()
        {
            string test = "Hello world!";
            var log = MironLog.GetInstance();
          
            MironLog.Log(test);
            var result = String.Join("\r\n", log.log);

            StringAssert.Contains(result, test);
            
        }

        [TestMethod()]
        public void WriteTest()
        {
            var currentConsoleOut = Console.Out;

            MironLog.Log("Hello");
            MironLog.Write();

            Assert.AreEqual(currentConsoleOut, Console.Out);
        }
    }
}