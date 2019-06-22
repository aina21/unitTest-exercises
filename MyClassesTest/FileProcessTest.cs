using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoeseExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        public void FileNameDoeseNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\BadFileName.bad");

            Assert.IsFalse(fromCall);
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            Assert.Inconclusive();
        }
    }
}
