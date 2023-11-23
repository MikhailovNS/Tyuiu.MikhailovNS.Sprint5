﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint5.Task6.V25.Lib;

using System.IO;

namespace Tyuiu.MikhailovNS.Sprint5.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Task61()
        {
            string path = @"C:\Sprint5\InPutDataFileTask6V25.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void Task62()
        {
            DataService ds = new DataService();

            string path = @"C:\Sprint5\InPutDataFileTask6V25.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}
