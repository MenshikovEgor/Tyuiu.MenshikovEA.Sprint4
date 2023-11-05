using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint4.Task2.V26.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 2, 3, 4, 5, 6, 7, 8, 1};

            int res = ds.Calculate(numsArray);
            int wait = 105;

            Assert.AreEqual(wait, res);
        }
    }
}
