using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UstuzhaninAA.Sprint2.Task5.V15.Lib;

namespace Tyuiu.UstuzhaninAA.Sprint2.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            // 1 день года — понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(1));

            // 7 день года — Воскресенье
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            // 8 день года — опять понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(8));

            // 365 день года — понедельник
            Assert.AreEqual("Понедельник", ds.FindDayName(365));
        }
    }
}