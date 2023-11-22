using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task5.V20.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task51()
        {
            string path = @"C:\Sprint5\InPutDataFileTask5V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void Task52()
        {
            DataService ds = new DataService();
            string path = @"C:\Sprint5\InPutDataFileTask5V20.txt";

            FileInfo fileInfo = new FileInfo(path);
            double res = ds.LoadFromDataFile(path);
            double wait = 2.439;

            Assert.AreEqual(wait, res);
        }
    }
}
