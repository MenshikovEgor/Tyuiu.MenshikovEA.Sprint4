using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint4.Task0.V13.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = {2, 6, 2, 3, 4, 5, 4, 9, 7, 8};
            int wait = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(26, wait);
        }
    }
}
