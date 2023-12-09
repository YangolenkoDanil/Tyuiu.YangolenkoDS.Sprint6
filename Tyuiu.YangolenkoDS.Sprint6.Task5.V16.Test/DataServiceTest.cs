using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.YangolenkoDS.Sprint6.Task5.V16.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile()
        {
            string path = @"C:\Users\angol\source\repos\Tyuiu.YangolenkoDS.Sprint6\Tyuiu.YangolenkoDS.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
