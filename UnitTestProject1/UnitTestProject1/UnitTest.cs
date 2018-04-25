
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreNotEqual<int>(1, 2, "Test1");
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreNotEqual<int>(1, 1, "Test2");
        }
    }
}
