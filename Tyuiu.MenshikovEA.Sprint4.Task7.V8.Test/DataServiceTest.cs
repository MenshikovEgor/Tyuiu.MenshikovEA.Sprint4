using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint4.Task7.V8.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string value = "264795863157";
            int n = 3;
            int m = 4;

            Assert.AreEqual(ds.Calculate(n, m, value), 37);
        }
    }
}
