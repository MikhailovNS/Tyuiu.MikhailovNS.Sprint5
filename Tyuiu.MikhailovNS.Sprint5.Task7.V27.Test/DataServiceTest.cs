using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task7.V27.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task7()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MikhailovNS.Sprint5\Tyuiu.MikhailovNS.Sprint5.Task7.V27\bin\Debug\OutPutDataFileTask7V27.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
