﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshikovEA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.MenshikovEA.Sprint4.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 5, 6, 5, 6, 5 }, { 5, 5, 5, 8, 4 }, { 8, 5, 5, 8, 8 }, { 6, 5, 4, 4, 8 }, { 8, 5, 6, 8, 8 } };

            int res = ds.Calculate(mas2);
            Assert.AreEqual(res, 100);
        }
    }
}
