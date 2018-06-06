using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamespaceFileSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class DirectoryTest
    {
        [TestMethod]
        public void AddDirectoryTest()
        {
            var parent = new Directory("ParentName");
            var subDir = new Directory("SubDir");
            parent.AddDirectory(subDir);
            CollectionAssert.Contains(parent.SubDirs, subDir);
        }

        [TestMethod]
        public void RemoveFileTest()
        {

        }
        [TestMethod]
        public void AddFileTest()
        {
            var f = new File("");
        }
    }
}
