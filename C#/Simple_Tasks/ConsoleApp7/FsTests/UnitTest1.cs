using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamespaceFileSystem;

namespace FsTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCreate()
        {
            var fileName = "fileName";
            var file = new File(fileName);

            Assert.AreEqual(fileName, file.Name);
        }
    }
}
