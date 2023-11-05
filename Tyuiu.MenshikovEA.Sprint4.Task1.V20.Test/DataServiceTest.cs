using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint4.Task1.V20.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 8, 0, 4, 7, 5, 3, 9, 2, 7, 0 };

            int wait = 31;
            int res = ds.Calculate(array);
            Assert.AreEqual(res, wait);
        }
    }
}
