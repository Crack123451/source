using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamespaceFileSystem;

namespace TestProject
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void TestCreate()
        {
            var fileName = "fileName";
            var file = new File(fileName);

            Assert.AreEqual(fileName, file.Name);
        }

        [TestMethod]
        public void TestEmpty()
        {
            var fileValue = 34;
            var file = new File("ghgj");
            file.SetValue(fileValue);

            Assert.AreEqual(fileValue, file.Value);
        }
    }
}