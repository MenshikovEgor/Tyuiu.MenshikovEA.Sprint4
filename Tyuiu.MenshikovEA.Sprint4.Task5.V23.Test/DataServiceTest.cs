using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -1, -2, 1, 2, 3 }, { 1, 2, 3, 4, -1 }, { -9, -8, -7, -6, 5 }, { 1, 2, 3, 4, 5 }, { 9, 8, 7, -4, -3 } };

            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5]{ { 0, 0, 1, 2, 3 }, { 1, 2, 3, 4, 0 }, { 0, 0, 0, 0, 5 }, { 1, 2, 3, 4, 5 }, { 9, 8, 7, 0, 0 } };

            Assert.AreEqual(wait, res);
        }
    }
}
