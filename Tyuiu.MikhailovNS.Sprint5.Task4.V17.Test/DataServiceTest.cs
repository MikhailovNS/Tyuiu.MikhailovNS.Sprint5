using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MikhailovNS.Sprint5.Task4.V17.Lib;

namespace Tyuiu.MikhailovNS.Sprint5.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task41()
        {
            string path = @"C:\Sprint5\InPutDataFileTask4V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void Task42()
        {
            DataService ds = new DataService();
            string path = @"C:\Sprint5\InPutDataFileTask4V17.txt";
            double res = ds.LoadFromDataFile(path);
            res = Math.Round(res, 3);
            double wait = 22.044;
            Assert.AreEqual(wait, res);
        }
    }
}
