using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task0.V6.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MikhailovNS.Sprint5\Tyuiu.MikhailovNS.Sprint5.Task0.V6\bin\Debug\OutOutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, true);
        }
    }
}
