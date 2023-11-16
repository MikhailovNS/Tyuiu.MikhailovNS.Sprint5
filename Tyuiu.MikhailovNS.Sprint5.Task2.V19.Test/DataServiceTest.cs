using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task2.V19.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task2()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MikhailovNS.Sprint5\Tyuiu.MikhailovNS.Sprint5.Task2.V19\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
