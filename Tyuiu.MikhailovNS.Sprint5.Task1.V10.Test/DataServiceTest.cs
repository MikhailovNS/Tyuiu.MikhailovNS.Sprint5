using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task1.V10.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MikhailovNS.Sprint5\Tyuiu.MikhailovNS.Sprint5.Task1.V10\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
