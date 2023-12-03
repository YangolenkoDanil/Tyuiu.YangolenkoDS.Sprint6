using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YangolenkoDS.Sprint6.Task0.V1.Lib;

namespace Tyuiu.YangolenkoDS.Sprint6.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int x = 3;
            double res = ds.Calculate(x);
            double wait = 0.103;

            Assert.AreEqual(wait, res);
        }
    }
}
