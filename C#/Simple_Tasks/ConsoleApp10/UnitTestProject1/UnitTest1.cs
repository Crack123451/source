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
            Assert.AreEqual(0, FirstOrDefault(new int[0], x => true)); // default(int) == 0
            Assert.AreEqual(null, FirstOrDefault(new string[0], x => true)); // default(string) == null
            Assert.AreEqual(3, FirstOrDefault(new[] { 1, 2, 3 }, x => x > 2));
            Assert.AreEqual(3, FirstOrDefault(new[] { 3, 2, 1 }, x => x > 2));
            Assert.AreEqual(3, FirstOrDefault(new[] { 2, 3, 1 }, x => x > 2));
        }
    }
}
