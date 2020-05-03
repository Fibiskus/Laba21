using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = -3;
            double y = (2 + x * 3) / (x + Math.Sqrt(13 * Math.Abs(x)));
            double result = ConsoleApp2._1.Program.Calculation(x);
            Assert.AreEqual(y, result);
        }
    }
}